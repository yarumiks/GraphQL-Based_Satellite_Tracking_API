# GraphQL-Based_Satellite_Tracking_API

#  Project Overview
A basic API application built with GraphQL, providing a server-focused architecture. It wraps free REST API data with GraphQL to create a reusable service layer.

## Application Concept
The service wraps N2YO’s satellite data with GraphQL, providing information on satellite positions and visibility. It displays estimated real-time positions of selected satellites on a map, and thanks to GraphQL subscriptions, clients automatically receive periodic updates after subscribing. Users can query satellites by their NORAD ID to obtain TLE data, pass predictions, current or estimated coordinates, and visibility information. Real-time tracking is supported through subscriptions for continuous position updates.



# 📌 Accessing Satellite IDs
Most queries require satellite NORAD IDs. While the API doesn’t provide them directly, N2YO’s satellite catalog lists types and totals.

The application also includes a local JSON file with IDs. You can inspect it manually or query by category to retrieve IDs.

```graphql
query {
  localSattellitesID(category: AmateurRadio) {
    name
    noradIds
  }
}
```

Response:

```graphql
{
  "data": {
    "localSattellitesID": [
      {
        "name": "Geodetic",
        "noradIds": [41240, 38038, 38011, 37216, 36605, ...]
      }
    ]
  }
}
```
<br></br>
>⚠️ Since the ID values in the local JSON file are manually defined by the program, not every category may have IDs. However, you can easily add ID values for any new categories you need. Below, the steps to do this are explained.
<br></br>
# 📌 Working with the Local Data File
In the application, some categories may not have satellite IDs (NORAD IDs) in the local JSON file. In such cases, 
the following queries and mutations can be used to add new values or update existing ones.

## 1️⃣ Check IDs
For example, if you run a query for the AmateurRadio category and no IDs exist:

```graphql
query {
  localSattellitesID(category: AmateurRadio) {
    name
    noradIds
  }
}
```
Response:

```graphql
{
  "errors": [
    {
      "message": "Value for the parameter given not found: 'AmateurRadio'",
      "extensions": {
        "code": "NOT_FOUND"
      }
    }
  ]
}
```
## 2️⃣ Adding New IDs
You can add NORAD ID values obtained from the N2YO website using the following mutation:

Single ID:
```graphql
mutation {
  addSatellite(name: AmateurRadio, noradIds: 36122) {
    name
    noradIds
  }
}
```
Multiple IDs:
```graphql
mutation {
  addSatellite(name: AmateurRadio, noradIds: [36122, 28895]) {
    name
    noradIds
  }
}
```
## 3️⃣ Check After Adding New IDs
When you run the query again:

```graphql
{
  "data": {
    "localSattellitesID": [
      {
        "name": "AmateurRadio",
        "noradIds": [
          36122,
          28895
        ]
      }
    ]
  }
}
```
## 4️⃣ Optional: Remove or Update IDs

Remove:

```graphql
mutation {
  removeSatellite(deleteId: 28895, name: AmateurRadio)
}
```

Update:
```graphql
mutation {
  updateSatellite(name: AmateurRadio, oldId: 28898, newId: 28895)
}
```
<br></br>
# 📌 TLE (Two-Line Element) Data
TLE (Two-Line Element) is a standard format used to describe the orbital elements of a satellite. These elements allow the calculation of the satellite's position and velocity at any given time.
```graphql
  query{
    tle(id:47486) {
      info {
        satId
        satName
        transactionsCount
      }
      tle
    }
  }
```

Response:
```graphql
{
  "data": {
    "tle": {
      "info": {
        "satId": 47486,
        "satName": "CELESTIS 17/SHERPA-FX1",
        "transactionsCount": 0
      },
      "tle": "1 47486U 21006CB  25246.00898656  .00011771  00000-0  43389-3 0  9996\r\n2 47486  97.2706 289.0245 0008531 133.2503 226.9451 15.27923341255385"
    }
  }
}
```
<br></br>

# 📌 Satellite Passes
The N2YO API provides two types of satellite pass information for a given observer location:

## 1️⃣ Radio Passes

Radio passes indicate the times when a satellite is above the horizon and can be tracked via radio signals. These are useful for amateur radio operators or telemetry reception.

## 2️⃣ Visual Passes

Visual passes indicate the times when a satellite is visible in the sky to the naked eye, usually at dawn or dusk when the satellite is illuminated by the sun but the observer is in darkness. These are useful for observation and photography.

<br></br>
> **Before using radio or visual passes, set your observer location (latitude, longitude, altitude). For example:**

```graphql
mutation {
 setObserverLocation(latitude: 40.4093, longitude: 49.8671, altitude: 100) {
   hasObserver
 }
}
```
After setting the location, you can query Radio Passes or Visual Passes for satellites.
<br></br>

Radio Passes:
```graphql
  query{
    radioPass(radioP: {
      id: 28895,
      days: 1,
      minElevation: 0
    }) {
      info {
        passesCount
        satId
        satName
        transactionsCount
      }
      passes {
        startAz
        startAzCompass
        startEl
        startUTC
        maxAz
        maxAzCompass
        maxEl
        maxUTC
        endAz
        endAzCompass
        endEl
        endUTC
      }
    }
  }
```

Visual Passes:
```graphql
query{
    visualVisibility(visualP: {
     id: 47486,
      days: 1,
      minVisibility: 0
    }) {
      info {
        passesCount
        satId
        satName
        transactionsCount
      }
       passes {
        startAz
        startAzCompass
        startEl
        startUTC
        maxAz
        maxAzCompass
        maxEl
        maxUTC
        endAz
        endAzCompass
        endEl
        endUTC
        mag
        duration
      }
    }
  }
```
<br></br>
