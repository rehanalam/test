# 

Marvel Comics API SDK



## Base URL

The Base URL for this API is `http://gateway.marvel.com`



## Authentication
The type of authentication used by this API is: `Custom Query Parameter`
### Authentication Parameters

The parameters required for authentication are listed below:

| Parameter | Description | Example | 
|-----------|-------------| ------- |
| apikey | This parameter must be provided in the query. | apikey |


### Additional Headers

Additional authentication headers that will be sent with your API requests are listed below:

| Parameter | Description | Example | 
|-----------|-------------| ------- |
| referer | TODO: Add a parameter description | `*.marvel.com` | 





# <a name="api_reference"></a>API Reference

* [Characters](#characters)
* [Comics](#comics)
* [Events](#events)
* [Series](#series)
* [Stories](#stories)
* [Creators](#creators)

## <a name="characters"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "Characters") Characters


### <a name="get_character_individual"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCharacterIndividual") `GET` /v1/public/characters/{characterId}

> Fetches a single character by id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characterId | `string` |  ``` Required ```  | A single character id. | `"characterId"` | 

#### Responses
**200** 

Body (_Character_) 
```
{
  "comics": {
    "available": 178,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 178
  },
  "description": "description",
  "events": {
    "available": 178,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 178
  },
  "id": 178,
  "modified": "2017-06-07T07:23:48.5397005Z",
  "name": "name",
  "resourceURI": "resourceURI",
  "series": {
    "available": 14,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 14
  },
  "stories": {
    "available": 14,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "type": "type"
      }
    ],
    "returned": 14
  },
  "thumbnail": {
    "extension": "extension",
    "path": "path"
  },
  "urls": [
    {
      "type": "type",
      "url": "url"
    }
  ]
}
```


**404** 

> Character not found.


### <a name="get_character_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCharacterCollection") `GET` /v1/public/characters

> Fetches lists of characters.



#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| events | `string` |  ``` Optional ```  | Return only characters which appear in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only characters which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") | `name` | 
| series | `string` |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). | `"stories"` | 

#### Responses
**200** 

Body (_CharacterDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 14,
  "copyright": "copyright",
  "data": {
    "count": 14,
    "limit": 14,
    "offset": 14,
    "results": [
      {
        "comics": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 14
        },
        "description": "description",
        "events": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 14
        },
        "id": 14,
        "modified": "2017-06-07T07:23:48.5487069Z",
        "name": "name",
        "resourceURI": "resourceURI",
        "series": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 14
        },
        "stories": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 14
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 14
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_comic_character_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getComicCharacterCollection") `GET` /v1/public/comics/{comicId}/characters

> Fetches lists of characters filtered by a comic id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comicId | `string` |  ``` Required ```  | The comic id. | `"comicId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| events | `string` |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only characters which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") | `name` | 
| series | `string` |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). | `"stories"` | 

#### Responses
**200** 

Body (_CharacterDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 14,
  "copyright": "copyright",
  "data": {
    "count": 14,
    "limit": 14,
    "offset": 14,
    "results": [
      {
        "comics": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 14
        },
        "description": "description",
        "events": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 14
        },
        "id": 14,
        "modified": "2017-06-07T07:23:48.5507078Z",
        "name": "name",
        "resourceURI": "resourceURI",
        "series": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 14
        },
        "stories": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 14
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 14
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_event_character_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getEventCharacterCollection") `GET` /v1/public/events/{eventId}/characters

> Fetches lists of characters filtered by an event id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| eventId | `string` |  ``` Required ```  | The event ID | `"eventId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only characters which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") | `name` | 
| series | `string` |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). | `"stories"` | 

#### Responses
**200** 

Body (_CharacterDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 14,
  "copyright": "copyright",
  "data": {
    "count": 14,
    "limit": 14,
    "offset": 14,
    "results": [
      {
        "comics": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 14
        },
        "description": "description",
        "events": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 14
        },
        "id": 14,
        "modified": "2017-06-07T07:23:48.5537109Z",
        "name": "name",
        "resourceURI": "resourceURI",
        "series": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 14
        },
        "stories": {
          "available": 14,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 14
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 14
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_series_character_wrapper"></a>![Endpoint: ](https://apidocs.io/img/method.png "getSeriesCharacterWrapper") `GET` /v1/public/series/{seriesId}/characters

> Fetches lists of characters filtered by a series id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| seriesId | `string` |  ``` Required ```  | The series id. | `"seriesId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| events | `string` |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only characters which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") | `name` | 
| stories | `string` |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). | `"stories"` | 

#### Responses
**200** 

Body (_CharacterDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 14,
  "copyright": "copyright",
  "data": {
    "count": 14,
    "limit": 14,
    "offset": 14,
    "results": [
      {
        "comics": {
          "available": 228,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 228
        },
        "description": "description",
        "events": {
          "available": 228,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 228
        },
        "id": 228,
        "modified": "2017-06-07T07:23:48.5567126Z",
        "name": "name",
        "resourceURI": "resourceURI",
        "series": {
          "available": 228,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 228
        },
        "stories": {
          "available": 228,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 228
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 228
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_character_collection_by_story_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCharacterCollectionByStoryId") `GET` /v1/public/stories/{storyId}/characters

> Fetches lists of characters filtered by a story id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| storyId | `string` |  ``` Required ```  | The story ID. | `"storyId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| events | `string` |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only characters which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") | `name` | 
| series | `string` |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). | `"series"` | 

#### Responses
**200** 

Body (_CharacterDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 228,
  "copyright": "copyright",
  "data": {
    "count": 228,
    "limit": 228,
    "offset": 228,
    "results": [
      {
        "comics": {
          "available": 228,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 228
        },
        "description": "description",
        "events": {
          "available": 228,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 228
        },
        "id": 228,
        "modified": "2017-06-07T07:23:48.572724Z",
        "name": "name",
        "resourceURI": "resourceURI",
        "series": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 64
        },
        "stories": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 64
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 64
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


[Back to API Reference](#api_reference)

## <a name="comics"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "Comics") Comics


### <a name="get_comics_character_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getComicsCharacterCollection") `GET` /v1/public/characters/{characterId}/comics

> Fetches lists of comics filtered by a character id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characterId | `string` |  ``` Required ```  | The character id. | `"characterId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| collaborators | `string` |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | `"collaborators"` | 
| creators | `string` |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| dateDescriptor | `dateDescriptor` |  ``` Optional ```  | Return comics within a predefined date range. | `"lastWeek"` | 
| dateRange | `string` |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | `"dateRange"` | 
| diamondCode | `string` |  ``` Optional ```  | Filter by diamond code. | `"diamondCode"` | 
| digitalId | `string` |  ``` Optional ```  | Filter by digital comic id. | `"digitalId"` | 
| ean | `string` |  ``` Optional ```  | Filter by EAN. | `"ean"` | 
| events | `string` |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| format | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| formatType | `formatType` |  ``` Optional ```  | Filter by the issue format type (comic or collection). | `"collection"` | 
| hasDigitalIssue | `string` |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") | `true` | 
| isbn | `string` |  ``` Optional ```  | Filter by ISBN. | `"isbn"` | 
| issn | `string` |  ``` Optional ```  | Filter by ISSN. | `"issn"` | 
| issueNumber | `string` |  ``` Optional ```  | Return only issues in series whose issue number matches the input. | `"issueNumber"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only comics which have been modified since the specified date. | `"modifiedSince"` | 
| noVariants | `string` |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") | `true` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") | `focDate` | 
| series | `string` |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 
| sharedAppearances | `string` |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | `"sharedAppearances"` | 
| startYear | `string` |  ``` Optional ```  | Return only issues in series whose start year matches the input. | `"startYear"` | 
| stories | `string` |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| title | `string` |  ``` Optional ```  | Return only issues in series whose title matches the input. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return only issues in series whose title starts with the input. | `"titleStartsWith"` | 
| upc | `string` |  ``` Optional ```  | Filter by UPC. | `"upc"` | 

#### Responses
**200** 

Body (_ComicDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 64,
  "copyright": "copyright",
  "data": {
    "count": 64,
    "limit": 64,
    "offset": 64,
    "results": [
      {
        "characters": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 64
        },
        "collectedIssues": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "collections": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "creators": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 64
        },
        "dates": [
          {
            "date": "2017-06-07T07:23:48.5757252Z",
            "type": "type"
          }
        ],
        "description": "description",
        "diamondCode": "diamondCode",
        "digitalId": 64,
        "ean": "ean",
        "events": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 64
        },
        "format": "format",
        "id": 64,
        "images": [
          {
            "extension": "extension",
            "path": "path"
          }
        ],
        "isbn": "isbn",
        "issn": "issn",
        "issueNumber": 64,
        "modified": "2017-06-07T07:23:48.5767263Z",
        "pageCount": 64,
        "prices": [
          {
            "price": 64.6564317725862,
            "type": "type"
          }
        ],
        "resourceURI": "resourceURI",
        "series": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "stories": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 64
        },
        "textObjects": [
          {
            "language": "language",
            "text": "text",
            "type": "type"
          }
        ],
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "upc": "upc",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ],
        "variantDescription": "variantDescription",
        "variants": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ]
      }
    ],
    "total": 64
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_comics_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getComicsCollection") `GET` /v1/public/comics

> Fetches lists of comics.



#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| collaborators | `string` |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). Accepts a comma-separated list of ids. | `"collaborators"` | 
| creators | `string` |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| dateDescriptor | `dateDescriptor` |  ``` Optional ```  | Return comics within a predefined date range. | `"lastWeek"` | 
| dateRange | `string` |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | `"dateRange"` | 
| diamondCode | `string` |  ``` Optional ```  | Filter by diamond code. | `"diamondCode"` | 
| digitalId | `string` |  ``` Optional ```  | Filter by digital comic id. | `"digitalId"` | 
| ean | `string` |  ``` Optional ```  | Filter by EAN. | `"ean"` | 
| events | `string` |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| format | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| formatType | `formatType` |  ``` Optional ```  | Filter by the issue format type (comic or collection). | `"collection"` | 
| hasDigitalIssue | `string` |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") | `true` | 
| isbn | `string` |  ``` Optional ```  | Filter by ISBN. | `"isbn"` | 
| issn | `string` |  ``` Optional ```  | Filter by ISSN. | `"issn"` | 
| issueNumber | `string` |  ``` Optional ```  | Return only issues in series whose issue number matches the input. | `"issueNumber"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only comics which have been modified since the specified date. | `"modifiedSince"` | 
| noVariants | `string` |  ``` Optional ```  ``` DefaultValue ```  | Exclude variants (alternate covers, secondary printings, director's cuts, etc.) from the result set. (Acceptable values are: "true") | `true` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") | `focDate` | 
| series | `string` |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 
| sharedAppearances | `string` |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). Accepts a comma-separated list of ids. | `"sharedAppearances"` | 
| startYear | `string` |  ``` Optional ```  | Return only issues in series whose start year matches the input. | `"startYear"` | 
| stories | `string` |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| title | `string` |  ``` Optional ```  | Return only issues in series whose title matches the input. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return only issues in series whose title starts with the input. | `"titleStartsWith"` | 
| upc | `string` |  ``` Optional ```  | Filter by UPC. | `"upc"` | 

#### Responses
**200** 

Body (_ComicDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 64,
  "copyright": "copyright",
  "data": {
    "count": 64,
    "limit": 64,
    "offset": 64,
    "results": [
      {
        "characters": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 64
        },
        "collectedIssues": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "collections": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "creators": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 64
        },
        "dates": [
          {
            "date": "2017-06-07T07:23:48.5787278Z",
            "type": "type"
          }
        ],
        "description": "description",
        "diamondCode": "diamondCode",
        "digitalId": 64,
        "ean": "ean",
        "events": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 64
        },
        "format": "format",
        "id": 64,
        "images": [
          {
            "extension": "extension",
            "path": "path"
          }
        ],
        "isbn": "isbn",
        "issn": "issn",
        "issueNumber": 64,
        "modified": "2017-06-07T07:23:48.5797285Z",
        "pageCount": 64,
        "prices": [
          {
            "price": 64.6564317725862,
            "type": "type"
          }
        ],
        "resourceURI": "resourceURI",
        "series": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "stories": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 64
        },
        "textObjects": [
          {
            "language": "language",
            "text": "text",
            "type": "type"
          }
        ],
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "upc": "upc",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ],
        "variantDescription": "variantDescription",
        "variants": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ]
      }
    ],
    "total": 64
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_comic_individual"></a>![Endpoint: ](https://apidocs.io/img/method.png "getComicIndividual") `GET` /v1/public/comics/{comicId}

> Fetches a single comic by id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comicId | `string` |  ``` Required ```  | A single comic. | `"comicId"` | 

#### Responses
**200** 

Body (_Comic_) 
```
{
  "characters": {
    "available": 64,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "role": "role"
      }
    ],
    "returned": 64
  },
  "collectedIssues": [
    {
      "name": "name",
      "resourceURI": "resourceURI"
    }
  ],
  "collections": [
    {
      "name": "name",
      "resourceURI": "resourceURI"
    }
  ],
  "creators": {
    "available": 64,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "role": "role"
      }
    ],
    "returned": 64
  },
  "dates": [
    {
      "date": "2017-06-07T07:23:48.5807292Z",
      "type": "type"
    }
  ],
  "description": "description",
  "diamondCode": "diamondCode",
  "digitalId": 64,
  "ean": "ean",
  "events": {
    "available": 64,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 64
  },
  "format": "format",
  "id": 64,
  "images": [
    {
      "extension": "extension",
      "path": "path"
    }
  ],
  "isbn": "isbn",
  "issn": "issn",
  "issueNumber": 64,
  "modified": "2017-06-07T07:23:48.5817299Z",
  "pageCount": 64,
  "prices": [
    {
      "price": 64.6564317725862,
      "type": "type"
    }
  ],
  "resourceURI": "resourceURI",
  "series": {
    "name": "name",
    "resourceURI": "resourceURI"
  },
  "stories": {
    "available": 64,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "type": "type"
      }
    ],
    "returned": 64
  },
  "textObjects": [
    {
      "language": "language",
      "text": "text",
      "type": "type"
    }
  ],
  "thumbnail": {
    "extension": "extension",
    "path": "path"
  },
  "title": "title",
  "upc": "upc",
  "urls": [
    {
      "type": "type",
      "url": "url"
    }
  ],
  "variantDescription": "variantDescription",
  "variants": [
    {
      "name": "name",
      "resourceURI": "resourceURI"
    }
  ]
}
```


**404** 

> Comic not found.


### <a name="get_comics_collection_by_creator_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getComicsCollectionByCreatorId") `GET` /v1/public/creators/{creatorId}/comics

> Fetches lists of comics filtered by a creator id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| creatorId | `string` |  ``` Required ```  | The creator ID. | `"creatorId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| collaborators | `string` |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | `"collaborators"` | 
| dateDescriptor | `dateDescriptor` |  ``` Optional ```  | Return comics within a predefined date range. | `"lastWeek"` | 
| dateRange | `string` |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | `"dateRange"` | 
| diamondCode | `string` |  ``` Optional ```  | Filter by diamond code. | `"diamondCode"` | 
| digitalId | `string` |  ``` Optional ```  | Filter by digital comic id. | `"digitalId"` | 
| ean | `string` |  ``` Optional ```  | Filter by EAN. | `"ean"` | 
| events | `string` |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| format | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| formatType | `formatType` |  ``` Optional ```  | Filter by the issue format type (comic or collection). | `"collection"` | 
| hasDigitalIssue | `string` |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") | `true` | 
| isbn | `string` |  ``` Optional ```  | Filter by ISBN. | `"isbn"` | 
| issn | `string` |  ``` Optional ```  | Filter by ISSN. | `"issn"` | 
| issueNumber | `string` |  ``` Optional ```  | Return only issues in series whose issue number matches the input. | `"issueNumber"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only comics which have been modified since the specified date. | `"modifiedSince"` | 
| noVariants | `string` |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") | `true` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") | `focDate` | 
| series | `string` |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 
| sharedAppearances | `string` |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | `"sharedAppearances"` | 
| startYear | `string` |  ``` Optional ```  | Return only issues in series whose start year matches the input. | `"startYear"` | 
| stories | `string` |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| title | `string` |  ``` Optional ```  | Return only issues in series whose title matches the input. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return only issues in series whose title starts with the input. | `"titleStartsWith"` | 
| upc | `string` |  ``` Optional ```  | Filter by UPC. | `"upc"` | 

#### Responses
**200** 

Body (_ComicDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 64,
  "copyright": "copyright",
  "data": {
    "count": 64,
    "limit": 64,
    "offset": 64,
    "results": [
      {
        "characters": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 64
        },
        "collectedIssues": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "collections": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "creators": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 64
        },
        "dates": [
          {
            "date": "2017-06-07T07:23:48.5837313Z",
            "type": "type"
          }
        ],
        "description": "description",
        "diamondCode": "diamondCode",
        "digitalId": 64,
        "ean": "ean",
        "events": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 64
        },
        "format": "format",
        "id": 64,
        "images": [
          {
            "extension": "extension",
            "path": "path"
          }
        ],
        "isbn": "isbn",
        "issn": "issn",
        "issueNumber": 64,
        "modified": "2017-06-07T07:23:48.5837313Z",
        "pageCount": 64,
        "prices": [
          {
            "price": 64.6564317725862,
            "type": "type"
          }
        ],
        "resourceURI": "resourceURI",
        "series": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "stories": {
          "available": 64,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 64
        },
        "textObjects": [
          {
            "language": "language",
            "text": "text",
            "type": "type"
          }
        ],
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "upc": "upc",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ],
        "variantDescription": "variantDescription",
        "variants": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ]
      }
    ],
    "total": 64
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_comics_collection_by_event_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getComicsCollectionByEventId") `GET` /v1/public/events/{eventId}/comics

> Fetches lists of comics filtered by an event id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| eventId | `string` |  ``` Required ```  | The event id. | `"eventId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| collaborators | `string` |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | `"collaborators"` | 
| creators | `string` |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| dateDescriptor | `dateDescriptor` |  ``` Optional ```  | Return comics within a predefined date range. | `"lastWeek"` | 
| dateRange | `string` |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | `"dateRange"` | 
| diamondCode | `string` |  ``` Optional ```  | Filter by diamond code. | `"diamondCode"` | 
| digitalId | `string` |  ``` Optional ```  | Filter by digital comic id. | `"digitalId"` | 
| ean | `string` |  ``` Optional ```  | Filter by EAN. | `"ean"` | 
| events | `string` |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| format | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| formatType | `formatType` |  ``` Optional ```  | Filter by the issue format type (comic or collection). | `"collection"` | 
| hasDigitalIssue | `string` |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") | `true` | 
| isbn | `string` |  ``` Optional ```  | Filter by ISBN. | `"isbn"` | 
| issn | `string` |  ``` Optional ```  | Filter by ISSN. | `"issn"` | 
| issueNumber | `string` |  ``` Optional ```  | Return only issues in series whose issue number matches the input. | `"issueNumber"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only comics which have been modified since the specified date. | `"modifiedSince"` | 
| noVariants | `string` |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") | `true` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") | `focDate` | 
| series | `string` |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 
| sharedAppearances | `string` |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | `"sharedAppearances"` | 
| startYear | `string` |  ``` Optional ```  | Return only issues in series whose start year matches the input. | `"startYear"` | 
| stories | `string` |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| title | `string` |  ``` Optional ```  | Return only issues in series whose title matches the input. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return only issues in series whose title starts with the input. | `"titleStartsWith"` | 
| upc | `string` |  ``` Optional ```  | Filter by UPC. | `"upc"` | 

#### Responses
**200** 

Body (_ComicDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 22,
  "copyright": "copyright",
  "data": {
    "count": 22,
    "limit": 22,
    "offset": 22,
    "results": [
      {
        "characters": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "collectedIssues": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "collections": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "creators": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "dates": [
          {
            "date": "2017-06-07T07:23:48.5887363Z",
            "type": "type"
          }
        ],
        "description": "description",
        "diamondCode": "diamondCode",
        "digitalId": 22,
        "ean": "ean",
        "events": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 22
        },
        "format": "format",
        "id": 22,
        "images": [
          {
            "extension": "extension",
            "path": "path"
          }
        ],
        "isbn": "isbn",
        "issn": "issn",
        "issueNumber": 22,
        "modified": "2017-06-07T07:23:48.5897361Z",
        "pageCount": 22,
        "prices": [
          {
            "price": 22.9332585460196,
            "type": "type"
          }
        ],
        "resourceURI": "resourceURI",
        "series": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "stories": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 22
        },
        "textObjects": [
          {
            "language": "language",
            "text": "text",
            "type": "type"
          }
        ],
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "upc": "upc",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ],
        "variantDescription": "variantDescription",
        "variants": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ]
      }
    ],
    "total": 22
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_comics_collection_by_series_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getComicsCollectionBySeriesId") `GET` /v1/public/series/{seriesId}/comics

> Fetches lists of comics filtered by a series id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| seriesId | `string` |  ``` Required ```  | The series ID. | `"seriesId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| collaborators | `string` |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | `"collaborators"` | 
| creators | `string` |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| dateDescriptor | `dateDescriptor` |  ``` Optional ```  | Return comics within a predefined date range. | `"lastWeek"` | 
| dateRange | `string` |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | `"dateRange"` | 
| diamondCode | `string` |  ``` Optional ```  | Filter by diamond code. | `"diamondCode"` | 
| digitalId | `string` |  ``` Optional ```  | Filter by digital comic id. | `"digitalId"` | 
| ean | `string` |  ``` Optional ```  | Filter by EAN. | `"ean"` | 
| events | `string` |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| format | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| formatType | `formatType` |  ``` Optional ```  | Filter by the issue format type (comic or collection). | `"collection"` | 
| hasDigitalIssue | `string` |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") | `true` | 
| isbn | `string` |  ``` Optional ```  | Filter by ISBN. | `"isbn"` | 
| issn | `string` |  ``` Optional ```  | Filter by ISSN. | `"issn"` | 
| issueNumber | `string` |  ``` Optional ```  | Return only issues in series whose issue number matches the input. | `"issueNumber"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only comics which have been modified since the specified date. | `"modifiedSince"` | 
| noVariants | `string` |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") | `true` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") | `focDate` | 
| sharedAppearances | `string` |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | `"sharedAppearances"` | 
| startYear | `string` |  ``` Optional ```  | Return only issues in series whose start year matches the input. | `"startYear"` | 
| stories | `string` |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| title | `string` |  ``` Optional ```  | Return only issues in series whose title matches the input. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return only issues in series whose title starts with the input. | `"titleStartsWith"` | 
| upc | `string` |  ``` Optional ```  | Filter by UPC. | `"upc"` | 

#### Responses
**200** 

Body (_ComicDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 22,
  "copyright": "copyright",
  "data": {
    "count": 22,
    "limit": 22,
    "offset": 22,
    "results": [
      {
        "characters": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "collectedIssues": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "collections": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "creators": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "dates": [
          {
            "date": "2017-06-07T07:23:48.5917366Z",
            "type": "type"
          }
        ],
        "description": "description",
        "diamondCode": "diamondCode",
        "digitalId": 22,
        "ean": "ean",
        "events": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 22
        },
        "format": "format",
        "id": 22,
        "images": [
          {
            "extension": "extension",
            "path": "path"
          }
        ],
        "isbn": "isbn",
        "issn": "issn",
        "issueNumber": 22,
        "modified": "2017-06-07T07:23:48.5927373Z",
        "pageCount": 22,
        "prices": [
          {
            "price": 22.9332585460196,
            "type": "type"
          }
        ],
        "resourceURI": "resourceURI",
        "series": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "stories": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 22
        },
        "textObjects": [
          {
            "language": "language",
            "text": "text",
            "type": "type"
          }
        ],
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "upc": "upc",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ],
        "variantDescription": "variantDescription",
        "variants": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ]
      }
    ],
    "total": 22
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_comics_collection_by_story_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getComicsCollectionByStoryId") `GET` /v1/public/stories/{storyId}/comics

> Fetches lists of comics filtered by a story id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| storyId | `string` |  ``` Required ```  | The story ID. | `"storyId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| collaborators | `string` |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). | `"collaborators"` | 
| creators | `string` |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| dateDescriptor | `dateDescriptor` |  ``` Optional ```  | Return comics within a predefined date range. | `"lastWeek"` | 
| dateRange | `string` |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. | `"dateRange"` | 
| diamondCode | `string` |  ``` Optional ```  | Filter by diamond code. | `"diamondCode"` | 
| digitalId | `string` |  ``` Optional ```  | Filter by digital comic id. | `"digitalId"` | 
| ean | `string` |  ``` Optional ```  | Filter by EAN. | `"ean"` | 
| events | `string` |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| format | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| formatType | `formatType` |  ``` Optional ```  | Filter by the issue format type (comic or collection). | `"collection"` | 
| hasDigitalIssue | `string` |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") | `true` | 
| isbn | `string` |  ``` Optional ```  | Filter by ISBN. | `"isbn"` | 
| issn | `string` |  ``` Optional ```  | Filter by ISSN. | `"issn"` | 
| issueNumber | `string` |  ``` Optional ```  | Return only issues in series whose issue number matches the input. | `"issueNumber"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only comics which have been modified since the specified date. | `"modifiedSince"` | 
| noVariants | `string` |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") | `true` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") | `focDate` | 
| series | `string` |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 
| sharedAppearances | `string` |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). | `"sharedAppearances"` | 
| startYear | `string` |  ``` Optional ```  | Return only issues in series whose start year matches the input. | `"startYear"` | 
| title | `string` |  ``` Optional ```  | Return only issues in series whose title matches the input. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return only issues in series whose title starts with the input. | `"titleStartsWith"` | 
| upc | `string` |  ``` Optional ```  | Filter by UPC. | `"upc"` | 

#### Responses
**200** 

Body (_ComicDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 22,
  "copyright": "copyright",
  "data": {
    "count": 22,
    "limit": 22,
    "offset": 22,
    "results": [
      {
        "characters": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "collectedIssues": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "collections": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ],
        "creators": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "dates": [
          {
            "date": "2017-06-07T07:23:48.5947387Z",
            "type": "type"
          }
        ],
        "description": "description",
        "diamondCode": "diamondCode",
        "digitalId": 22,
        "ean": "ean",
        "events": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 22
        },
        "format": "format",
        "id": 22,
        "images": [
          {
            "extension": "extension",
            "path": "path"
          }
        ],
        "isbn": "isbn",
        "issn": "issn",
        "issueNumber": 22,
        "modified": "2017-06-07T07:23:48.5957394Z",
        "pageCount": 22,
        "prices": [
          {
            "price": 22.9332585460196,
            "type": "type"
          }
        ],
        "resourceURI": "resourceURI",
        "series": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "stories": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 22
        },
        "textObjects": [
          {
            "language": "language",
            "text": "text",
            "type": "type"
          }
        ],
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "upc": "upc",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ],
        "variantDescription": "variantDescription",
        "variants": [
          {
            "name": "name",
            "resourceURI": "resourceURI"
          }
        ]
      }
    ],
    "total": 22
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


[Back to API Reference](#api_reference)

## <a name="events"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "Events") Events


### <a name="get_character_events_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCharacterEventsCollection") `GET` /v1/public/characters/{characterId}/events

> Fetches lists of events filtered by a character id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characterId | `string` |  ``` Required ```  | The character ID. | `"characterId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| creators | `string` |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only events which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Filter the event list by name. | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") | `name` | 
| series | `string` |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 

#### Responses
**200** 

Body (_EventDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 22,
  "copyright": "copyright",
  "data": {
    "count": 22,
    "limit": 22,
    "offset": 22,
    "results": [
      {
        "characters": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "comics": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 22
        },
        "creators": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "description": "description",
        "end": "2017-06-07T07:23:48.5977408Z",
        "id": 22,
        "modified": "2017-06-07T07:23:48.5977408Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 22
        },
        "start": "2017-06-07T07:23:48.5977408Z",
        "stories": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 22
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 22
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_issue_events_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getIssueEventsCollection") `GET` /v1/public/comics/{comicId}/events

> Fetches lists of events filtered by a comic id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comicId | `string` |  ``` Required ```  | The comic ID. | `"comicId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| creators | `string` |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only events which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Filter the event list by name. | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") | `name` | 
| series | `string` |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 

#### Responses
**200** 

Body (_EventDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 22,
  "copyright": "copyright",
  "data": {
    "count": 22,
    "limit": 22,
    "offset": 22,
    "results": [
      {
        "characters": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "comics": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 22
        },
        "creators": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "description": "description",
        "end": "2017-06-07T07:23:48.5997423Z",
        "id": 22,
        "modified": "2017-06-07T07:23:48.5997423Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 22
        },
        "start": "2017-06-07T07:23:48.5997423Z",
        "stories": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 22
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 22
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_creator_events_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCreatorEventsCollection") `GET` /v1/public/creators/{creatorId}/events

> Fetches lists of events filtered by a creator id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| creatorId | `string` |  ``` Required ```  | The creator ID. | `"creatorId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only events which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Filter the event list by name. | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") | `name` | 
| series | `string` |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 

#### Responses
**200** 

Body (_EventDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 22,
  "copyright": "copyright",
  "data": {
    "count": 22,
    "limit": 22,
    "offset": 22,
    "results": [
      {
        "characters": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "comics": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 22
        },
        "creators": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 22
        },
        "description": "description",
        "end": "2017-06-07T07:23:48.6017437Z",
        "id": 22,
        "modified": "2017-06-07T07:23:48.6017437Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 22
        },
        "start": "2017-06-07T07:23:48.6027453Z",
        "stories": {
          "available": 22,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 22
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 22
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_event_individual"></a>![Endpoint: ](https://apidocs.io/img/method.png "getEventIndividual") `GET` /v1/public/events/{eventId}

> Fetches a single event by id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| eventId | `string` |  ``` Required ```  | A single event. | `"eventId"` | 

#### Responses
**200** 

Body (_Event_) 
```
{
  "characters": {
    "available": 114,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "role": "role"
      }
    ],
    "returned": 114
  },
  "comics": {
    "available": 114,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 114
  },
  "creators": {
    "available": 114,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "role": "role"
      }
    ],
    "returned": 114
  },
  "description": "description",
  "end": "2017-06-07T07:23:48.603747Z",
  "id": 114,
  "modified": "2017-06-07T07:23:48.603747Z",
  "next": {
    "name": "name",
    "resourceURI": "resourceURI"
  },
  "previous": {
    "name": "name",
    "resourceURI": "resourceURI"
  },
  "resourceURI": "resourceURI",
  "series": {
    "available": 114,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 114
  },
  "start": "2017-06-07T07:23:48.6047472Z",
  "stories": {
    "available": 114,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "type": "type"
      }
    ],
    "returned": 114
  },
  "thumbnail": {
    "extension": "extension",
    "path": "path"
  },
  "title": "title",
  "urls": [
    {
      "type": "type",
      "url": "url"
    }
  ]
}
```


**404** 

> Event not found.


### <a name="get_events_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getEventsCollection") `GET` /v1/public/events

> Fetches lists of events.



#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| creators | `string` |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only events which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Return only events which match the specified name. | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") | `name` | 
| series | `string` |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only events which take place in the specified stories (accepts a comma-separated list of ids). | `"stories"` | 

#### Responses
**200** 

Body (_EventDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 114,
  "copyright": "copyright",
  "data": {
    "count": 114,
    "limit": 114,
    "offset": 114,
    "results": [
      {
        "characters": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 114
        },
        "comics": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 114
        },
        "creators": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 114
        },
        "description": "description",
        "end": "2017-06-07T07:23:48.6067482Z",
        "id": 114,
        "modified": "2017-06-07T07:23:48.6067482Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 114
        },
        "start": "2017-06-07T07:23:48.6067482Z",
        "stories": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 114
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 114
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_events_collection_by_series_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getEventsCollectionBySeriesId") `GET` /v1/public/series/{seriesId}/events

> Fetches lists of events filtered by a series id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| seriesId | `string` |  ``` Required ```  | The series ID. | `"seriesId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| creators | `string` |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only events which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Filter the event list by name. | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") | `name` | 
| stories | `string` |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 

#### Responses
**200** 

Body (_EventDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 114,
  "copyright": "copyright",
  "data": {
    "count": 114,
    "limit": 114,
    "offset": 114,
    "results": [
      {
        "characters": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 114
        },
        "comics": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 114
        },
        "creators": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 114
        },
        "description": "description",
        "end": "2017-06-07T07:23:48.6097498Z",
        "id": 114,
        "modified": "2017-06-07T07:23:48.6097498Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 114
        },
        "start": "2017-06-07T07:23:48.6097498Z",
        "stories": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 114
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 114
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_events_collection_by_story_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getEventsCollectionByStoryId") `GET` /v1/public/stories/{storyId}/events

> Fetches lists of events filtered by a story id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| storyId | `string` |  ``` Required ```  | The story ID. | `"storyId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| creators | `string` |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only events which have been modified since the specified date. | `"modifiedSince"` | 
| name | `string` |  ``` Optional ```  | Filter the event list by name. | `"name"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") | `name` | 
| series | `string` |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). | `"series"` | 

#### Responses
**200** 

Body (_EventDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 114,
  "copyright": "copyright",
  "data": {
    "count": 114,
    "limit": 114,
    "offset": 114,
    "results": [
      {
        "characters": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 114
        },
        "comics": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 114
        },
        "creators": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 114
        },
        "description": "description",
        "end": "2017-06-07T07:23:48.6137527Z",
        "id": 114,
        "modified": "2017-06-07T07:23:48.6137527Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 114
        },
        "start": "2017-06-07T07:23:48.6137527Z",
        "stories": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 114
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 114
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


[Back to API Reference](#api_reference)

## <a name="series"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "Series") Series


### <a name="get_character_series_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCharacterSeriesCollection") `GET` /v1/public/characters/{characterId}/series

> Fetches lists of series filtered by a character id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characterId | `string` |  ``` Required ```  | The character ID | `"characterId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| contains | `string` |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| creators | `string` |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| events | `string` |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only series which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") | `title` | 
| seriesType | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") | `collection` | 
| startYear | `string` |  ``` Optional ```  | Return only series matching the specified start year. | `"startYear"` | 
| stories | `string` |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| title | `string` |  ``` Optional ```  | Filter by series title. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). | `"titleStartsWith"` | 

#### Responses
**200** 

Body (_SeriesDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 114,
  "copyright": "copyright",
  "data": {
    "count": 114,
    "limit": 114,
    "offset": 114,
    "results": [
      {
        "characters": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 114
        },
        "comics": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 114
        },
        "creators": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 114
        },
        "description": "description",
        "endYear": 114,
        "events": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 114
        },
        "id": 114,
        "modified": "2017-06-07T07:23:48.6177555Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "rating": "rating",
        "resourceURI": "resourceURI",
        "startYear": 114,
        "stories": {
          "available": 114,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 114
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 205
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_series_individual"></a>![Endpoint: ](https://apidocs.io/img/method.png "getSeriesIndividual") `GET` /v1/public/series/{seriesId}

> Fetches a single comic series by id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| seriesId | `string` |  ``` Required ```  | Filter by series title. | `"seriesId"` | 

#### Responses
**200** 

Body (_Series_) 
```
{
  "characters": {
    "available": 205,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "role": "role"
      }
    ],
    "returned": 205
  },
  "comics": {
    "available": 205,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 205
  },
  "creators": {
    "available": 205,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "role": "role"
      }
    ],
    "returned": 205
  },
  "description": "description",
  "endYear": 205,
  "events": {
    "available": 205,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 205
  },
  "id": 205,
  "modified": "2017-06-07T07:23:48.6217593Z",
  "next": {
    "name": "name",
    "resourceURI": "resourceURI"
  },
  "previous": {
    "name": "name",
    "resourceURI": "resourceURI"
  },
  "rating": "rating",
  "resourceURI": "resourceURI",
  "startYear": 205,
  "stories": {
    "available": 205,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "type": "type"
      }
    ],
    "returned": 205
  },
  "thumbnail": {
    "extension": "extension",
    "path": "path"
  },
  "title": "title",
  "urls": [
    {
      "type": "type",
      "url": "url"
    }
  ]
}
```


**404** 

> Series not found.


### <a name="get_creator_series_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCreatorSeriesCollection") `GET` /v1/public/creators/{creatorId}/series

> Fetches lists of series filtered by a creator id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| creatorId | `string` |  ``` Required ```  | The creator ID. | `"creatorId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| contains | `string` |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| events | `string` |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only series which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") | `title` | 
| seriesType | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") | `collection` | 
| startYear | `string` |  ``` Optional ```  | Return only series matching the specified start year. | `"startYear"` | 
| stories | `string` |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| title | `string` |  ``` Optional ```  | Filter by series title. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). | `"titleStartsWith"` | 

#### Responses
**200** 

Body (_SeriesDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 205,
  "copyright": "copyright",
  "data": {
    "count": 205,
    "limit": 205,
    "offset": 205,
    "results": [
      {
        "characters": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "comics": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "creators": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "description": "description",
        "endYear": 205,
        "events": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "id": 205,
        "modified": "2017-06-07T07:23:48.6247605Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "rating": "rating",
        "resourceURI": "resourceURI",
        "startYear": 205,
        "stories": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 205
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 205
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_event_series_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getEventSeriesCollection") `GET` /v1/public/events/{eventId}/series

> Fetches lists of series filtered by an event id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| eventId | `string` |  ``` Required ```  | The event ID. | `"eventId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| contains | `string` |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| creators | `string` |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only series which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") | `title` | 
| seriesType | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") | `collection` | 
| startYear | `string` |  ``` Optional ```  | Return only series matching the specified start year. | `"startYear"` | 
| stories | `string` |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| title | `string` |  ``` Optional ```  | Filter by series title. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). | `"titleStartsWith"` | 

#### Responses
**200** 

Body (_SeriesDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 205,
  "copyright": "copyright",
  "data": {
    "count": 205,
    "limit": 205,
    "offset": 205,
    "results": [
      {
        "characters": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "comics": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "creators": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "description": "description",
        "endYear": 205,
        "events": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "id": 205,
        "modified": "2017-06-07T07:23:48.6267619Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "rating": "rating",
        "resourceURI": "resourceURI",
        "startYear": 205,
        "stories": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 205
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 205
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_series_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getSeriesCollection") `GET` /v1/public/series

> Fetches lists of series.



#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| contains | `string` |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| creators | `string` |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| events | `string` |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only series which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") | `title` | 
| seriesType | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") | `collection` | 
| startYear | `string` |  ``` Optional ```  | Return only series matching the specified start year. | `"startYear"` | 
| stories | `string` |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| title | `string` |  ``` Optional ```  | Return only series matching the specified title. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). | `"titleStartsWith"` | 

#### Responses
**200** 

Body (_SeriesDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 205,
  "copyright": "copyright",
  "data": {
    "count": 205,
    "limit": 205,
    "offset": 205,
    "results": [
      {
        "characters": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "comics": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "creators": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "description": "description",
        "endYear": 205,
        "events": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "id": 205,
        "modified": "2017-06-07T07:23:48.6287638Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "rating": "rating",
        "resourceURI": "resourceURI",
        "startYear": 205,
        "stories": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 205
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 205
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_story_series_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getStorySeriesCollection") `GET` /v1/public/stories/{storyId}/series

> Fetches lists of series filtered by a story id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| storyId | `string` |  ``` Required ```  | The story ID. | `"storyId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| contains | `string` |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") | `comic` | 
| creators | `string` |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| events | `string` |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only series which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") | `title` | 
| seriesType | `string` |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") | `collection` | 
| startYear | `string` |  ``` Optional ```  | Return only series matching the specified start year. | `"startYear"` | 
| title | `string` |  ``` Optional ```  | Filter by series title. | `"title"` | 
| titleStartsWith | `string` |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). | `"titleStartsWith"` | 

#### Responses
**200** 

Body (_SeriesDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 205,
  "copyright": "copyright",
  "data": {
    "count": 205,
    "limit": 205,
    "offset": 205,
    "results": [
      {
        "characters": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "comics": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "creators": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "description": "description",
        "endYear": 205,
        "events": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "id": 205,
        "modified": "2017-06-07T07:23:48.6307648Z",
        "next": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "previous": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "rating": "rating",
        "resourceURI": "resourceURI",
        "startYear": 205,
        "stories": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 205
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 205
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


[Back to API Reference](#api_reference)

## <a name="stories"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "Stories") Stories


### <a name="get_character_story_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCharacterStoryCollection") `GET` /v1/public/characters/{characterId}/stories

> Fetches lists of stories filtered by a character id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characterId | `string` |  ``` Required ```  | The character ID. | `"characterId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). | `"comics"` | 
| creators | `string` |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| events | `string` |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only stories which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") | `id` | 
| series | `string` |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). | `"series"` | 

#### Responses
**200** 

Body (_StoryDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 205,
  "copyright": "copyright",
  "data": {
    "count": 205,
    "limit": 205,
    "offset": 205,
    "results": [
      {
        "characters": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "comics": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "creators": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 205
        },
        "description": "description",
        "events": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "id": 205,
        "modified": "2017-06-07T07:23:48.6327662Z",
        "originalissue": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 205,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 205
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "type": "type"
      }
    ],
    "total": 205
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_comic_story_collection_by_comic_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getComicStoryCollectionByComicId") `GET` /v1/public/comics/{comicId}/stories

> Fetches lists of stories filtered by a comic id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comicId | `string` |  ``` Required ```  | The comic ID. | `"comicId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| creators | `string` |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| events | `string` |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only stories which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") | `id` | 
| series | `string` |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). | `"series"` | 

#### Responses
**200** 

Body (_StoryDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 164,
  "copyright": "copyright",
  "data": {
    "count": 164,
    "limit": 164,
    "offset": 164,
    "results": [
      {
        "characters": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "comics": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "creators": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "description": "description",
        "events": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "id": 164,
        "modified": "2017-06-07T07:23:48.6357693Z",
        "originalissue": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "type": "type"
      }
    ],
    "total": 164
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_creator_story_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCreatorStoryCollection") `GET` /v1/public/creators/{creatorId}/stories

> Fetches lists of stories filtered by a creator id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| creatorId | `string` |  ``` Required ```  | The ID of the creator. | `"creatorId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only stories contained in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| events | `string` |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only stories which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") | `id` | 
| series | `string` |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). | `"series"` | 

#### Responses
**200** 

Body (_StoryDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 164,
  "copyright": "copyright",
  "data": {
    "count": 164,
    "limit": 164,
    "offset": 164,
    "results": [
      {
        "characters": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "comics": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "creators": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "description": "description",
        "events": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "id": 164,
        "modified": "2017-06-07T07:23:48.6377707Z",
        "originalissue": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "type": "type"
      }
    ],
    "total": 164
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_story_individual"></a>![Endpoint: ](https://apidocs.io/img/method.png "getStoryIndividual") `GET` /v1/public/stories/{storyId}

> Fetches a single comic story by id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| storyId | `string` |  ``` Required ```  | Filter by story id. | `"storyId"` | 

#### Responses
**200** 

Body (_Story_) 
```
{
  "characters": {
    "available": 164,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "role": "role"
      }
    ],
    "returned": 164
  },
  "comics": {
    "available": 164,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 164
  },
  "creators": {
    "available": 164,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "role": "role"
      }
    ],
    "returned": 164
  },
  "description": "description",
  "events": {
    "available": 164,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 164
  },
  "id": 164,
  "modified": "2017-06-07T07:23:48.6407719Z",
  "originalissue": {
    "name": "name",
    "resourceURI": "resourceURI"
  },
  "resourceURI": "resourceURI",
  "series": {
    "available": 164,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 164
  },
  "thumbnail": {
    "extension": "extension",
    "path": "path"
  },
  "title": "title",
  "type": "type"
}
```


**404** 

> Story not found.


### <a name="get_event_story_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getEventStoryCollection") `GET` /v1/public/events/{eventId}/stories

> Fetches lists of stories filtered by an event id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| eventId | `string` |  ``` Required ```  | The ID of the event. | `"eventId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). | `"comics"` | 
| creators | `string` |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only stories which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") | `id` | 
| series | `string` |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). | `"series"` | 

#### Responses
**200** 

Body (_StoryDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 164,
  "copyright": "copyright",
  "data": {
    "count": 164,
    "limit": 164,
    "offset": 164,
    "results": [
      {
        "characters": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "comics": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "creators": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "description": "description",
        "events": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "id": 164,
        "modified": "2017-06-07T07:23:48.6417722Z",
        "originalissue": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "type": "type"
      }
    ],
    "total": 164
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_series_story_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getSeriesStoryCollection") `GET` /v1/public/series/{seriesId}/stories

> Fetches lists of stories filtered by a series id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| seriesId | `string` |  ``` Required ```  | The series ID. | `"seriesId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). | `"comics"` | 
| creators | `string` |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| events | `string` |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only stories which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") | `id` | 

#### Responses
**200** 

Body (_StoryDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 164,
  "copyright": "copyright",
  "data": {
    "count": 164,
    "limit": 164,
    "offset": 164,
    "results": [
      {
        "characters": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "comics": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "creators": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "description": "description",
        "events": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "id": 164,
        "modified": "2017-06-07T07:23:48.6437736Z",
        "originalissue": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "type": "type"
      }
    ],
    "total": 164
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_story_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getStoryCollection") `GET` /v1/public/stories

> Fetches lists of stories.



#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| characters | `string` |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). | `"characters"` | 
| comics | `string` |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). | `"comics"` | 
| creators | `string` |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). | `"creators"` | 
| events | `string` |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). | `"events"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only stories which have been modified since the specified date. | `"modifiedSince"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") | `id` | 
| series | `string` |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). | `"series"` | 

#### Responses
**200** 

Body (_StoryDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 164,
  "copyright": "copyright",
  "data": {
    "count": 164,
    "limit": 164,
    "offset": 164,
    "results": [
      {
        "characters": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "comics": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "creators": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "role": "role"
            }
          ],
          "returned": 164
        },
        "description": "description",
        "events": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "id": 164,
        "modified": "2017-06-07T07:23:48.6467762Z",
        "originalissue": {
          "name": "name",
          "resourceURI": "resourceURI"
        },
        "resourceURI": "resourceURI",
        "series": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "title": "title",
        "type": "type"
      }
    ],
    "total": 164
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


[Back to API Reference](#api_reference)

## <a name="creators"></a>![Endpoint Group: ](https://apidocs.io/img/class.png "Creators") Creators


### <a name="get_creator_collection_by_comic_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCreatorCollectionByComicId") `GET` /v1/public/comics/{comicId}/creators

> Fetches lists of creators filtered by a comic id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comicId | `string` |  ``` Required ```  | The comic id. | `"comicId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| firstName | `string` |  ``` Optional ```  | Filter by creator first name (e.g. brian). | `"firstName"` | 
| firstNameStartsWith | `string` |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). | `"firstNameStartsWith"` | 
| lastName | `string` |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). | `"lastName"` | 
| lastNameStartsWith | `string` |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). | `"lastNameStartsWith"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| middleName | `string` |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). | `"middleName"` | 
| middleNameStartsWith | `string` |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). | `"middleNameStartsWith"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only creators which have been modified since the specified date. | `"modifiedSince"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") | `lastName` | 
| series | `string` |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| suffix | `string` |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). | `"suffix"` | 

#### Responses
**200** 

Body (_CreatorDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 164,
  "copyright": "copyright",
  "data": {
    "count": 164,
    "limit": 164,
    "offset": 164,
    "results": [
      {
        "comics": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "events": {
          "available": 164,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 164
        },
        "firstName": "firstName",
        "fullName": "fullName",
        "id": 164,
        "lastName": "lastName",
        "middleName": "middleName",
        "modified": "2017-06-07T07:23:48.6497783Z",
        "resourceURI": "resourceURI",
        "series": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "stories": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 0
        },
        "suffix": "suffix",
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 0
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_creator_collection"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCreatorCollection") `GET` /v1/public/creators

> Fetches lists of creators.



#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| events | `string` |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| firstName | `string` |  ``` Optional ```  | Filter by creator first name (e.g. Brian). | `"firstName"` | 
| firstNameStartsWith | `string` |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). | `"firstNameStartsWith"` | 
| lastName | `string` |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). | `"lastName"` | 
| lastNameStartsWith | `string` |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). | `"lastNameStartsWith"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| middleName | `string` |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). | `"middleName"` | 
| middleNameStartsWith | `string` |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). | `"middleNameStartsWith"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only creators which have been modified since the specified date. | `"modifiedSince"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") | `lastName` | 
| series | `string` |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| suffix | `string` |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). | `"suffix"` | 

#### Responses
**200** 

Body (_CreatorDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 0,
  "copyright": "copyright",
  "data": {
    "count": 0,
    "limit": 0,
    "offset": 0,
    "results": [
      {
        "comics": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "events": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "firstName": "firstName",
        "fullName": "fullName",
        "id": 0,
        "lastName": "lastName",
        "middleName": "middleName",
        "modified": "2017-06-07T07:23:48.6537821Z",
        "resourceURI": "resourceURI",
        "series": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "stories": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 0
        },
        "suffix": "suffix",
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 0
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_creator_individual"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCreatorIndividual") `GET` /v1/public/creators/{creatorId}

> Fetches a single creator by id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| creatorId | `string` |  ``` Required ```  | A single creator id. | `"creatorId"` | 

#### Responses
**200** 

Body (_Creator_) 
```
{
  "comics": {
    "available": 0,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 0
  },
  "events": {
    "available": 0,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 0
  },
  "firstName": "firstName",
  "fullName": "fullName",
  "id": 0,
  "lastName": "lastName",
  "middleName": "middleName",
  "modified": "2017-06-07T07:23:48.6567838Z",
  "resourceURI": "resourceURI",
  "series": {
    "available": 0,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI"
      }
    ],
    "returned": 0
  },
  "stories": {
    "available": 0,
    "collectionURI": "collectionURI",
    "items": [
      {
        "name": "name",
        "resourceURI": "resourceURI",
        "type": "type"
      }
    ],
    "returned": 0
  },
  "suffix": "suffix",
  "thumbnail": {
    "extension": "extension",
    "path": "path"
  },
  "urls": [
    {
      "type": "type",
      "url": "url"
    }
  ]
}
```


**404** 

> Creator not found.


### <a name="get_creator_collection_by_event_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCreatorCollectionByEventId") `GET` /v1/public/events/{eventId}/creators

> Fetches lists of creators filtered by an event id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| eventId | `string` |  ``` Required ```  | The event ID. | `"eventId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| firstName | `string` |  ``` Optional ```  | Filter by creator first name (e.g. brian). | `"firstName"` | 
| firstNameStartsWith | `string` |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). | `"firstNameStartsWith"` | 
| lastName | `string` |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). | `"lastName"` | 
| lastNameStartsWith | `string` |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). | `"lastNameStartsWith"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| middleName | `string` |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). | `"middleName"` | 
| middleNameStartsWith | `string` |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). | `"middleNameStartsWith"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only creators which have been modified since the specified date. | `"modifiedSince"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") | `lastName` | 
| series | `string` |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). | `"series"` | 
| stories | `string` |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| suffix | `string` |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). | `"suffix"` | 

#### Responses
**200** 

Body (_CreatorDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 0,
  "copyright": "copyright",
  "data": {
    "count": 0,
    "limit": 0,
    "offset": 0,
    "results": [
      {
        "comics": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "events": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "firstName": "firstName",
        "fullName": "fullName",
        "id": 0,
        "lastName": "lastName",
        "middleName": "middleName",
        "modified": "2017-06-07T07:23:48.657784Z",
        "resourceURI": "resourceURI",
        "series": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "stories": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 0
        },
        "suffix": "suffix",
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 0
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_creator_collection_by_series_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCreatorCollectionBySeriesId") `GET` /v1/public/series/{seriesId}/creators

> Fetches lists of creators filtered by a series id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| seriesId | `string` |  ``` Required ```  | The series ID. | `"seriesId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| events | `string` |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| firstName | `string` |  ``` Optional ```  | Filter by creator first name (e.g. brian). | `"firstName"` | 
| firstNameStartsWith | `string` |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). | `"firstNameStartsWith"` | 
| lastName | `string` |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). | `"lastName"` | 
| lastNameStartsWith | `string` |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). | `"lastNameStartsWith"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| middleName | `string` |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). | `"middleName"` | 
| middleNameStartsWith | `string` |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). | `"middleNameStartsWith"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only creators which have been modified since the specified date. | `"modifiedSince"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") | `lastName` | 
| stories | `string` |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). | `"stories"` | 
| suffix | `string` |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). | `"suffix"` | 

#### Responses
**200** 

Body (_CreatorDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 0,
  "copyright": "copyright",
  "data": {
    "count": 0,
    "limit": 0,
    "offset": 0,
    "results": [
      {
        "comics": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "events": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "firstName": "firstName",
        "fullName": "fullName",
        "id": 0,
        "lastName": "lastName",
        "middleName": "middleName",
        "modified": "2017-06-07T07:23:48.6597854Z",
        "resourceURI": "resourceURI",
        "series": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "stories": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 0
        },
        "suffix": "suffix",
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 0
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


### <a name="get_creator_collection_by_story_id"></a>![Endpoint: ](https://apidocs.io/img/method.png "getCreatorCollectionByStoryId") `GET` /v1/public/stories/{storyId}/creators

> Fetches lists of creators filtered by a story id.



#### Path Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| storyId | `string` |  ``` Required ```  | The story ID. | `"storyId"` | 

#### Query Parameters
| Parameter | Type | Tags | Description | Example |
|-----------|------| ---- |-------------| ------- |
| comics | `string` |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). | `"comics"` | 
| events | `string` |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). | `"events"` | 
| firstName | `string` |  ``` Optional ```  | Filter by creator first name (e.g. brian). | `"firstName"` | 
| firstNameStartsWith | `string` |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). | `"firstNameStartsWith"` | 
| lastName | `string` |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). | `"lastName"` | 
| lastNameStartsWith | `string` |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). | `"lastNameStartsWith"` | 
| limit | `string` |  ``` Optional ```  | Limit the result set to the specified number of resources. | `"limit"` | 
| middleName | `string` |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). | `"middleName"` | 
| middleNameStartsWith | `string` |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). | `"middleNameStartsWith"` | 
| modifiedSince | `string` |  ``` Optional ```  | Return only creators which have been modified since the specified date. | `"modifiedSince"` | 
| nameStartsWith | `string` |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). | `"nameStartsWith"` | 
| offset | `string` |  ``` Optional ```  | Skip the specified number of resources in the result set. | `"offset"` | 
| orderBy | `string` |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") | `lastName` | 
| series | `string` |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). | `"series"` | 
| suffix | `string` |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). | `"suffix"` | 

#### Responses
**200** 

Body (_CreatorDataWrapper_) 
```
{
  "attributionHTML": "attributionHTML",
  "attributionText": "attributionText",
  "code": 0,
  "copyright": "copyright",
  "data": {
    "count": 0,
    "limit": 0,
    "offset": 0,
    "results": [
      {
        "comics": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "events": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "firstName": "firstName",
        "fullName": "fullName",
        "id": 0,
        "lastName": "lastName",
        "middleName": "middleName",
        "modified": "2017-06-07T07:23:48.6617869Z",
        "resourceURI": "resourceURI",
        "series": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI"
            }
          ],
          "returned": 0
        },
        "stories": {
          "available": 0,
          "collectionURI": "collectionURI",
          "items": [
            {
              "name": "name",
              "resourceURI": "resourceURI",
              "type": "type"
            }
          ],
          "returned": 0
        },
        "suffix": "suffix",
        "thumbnail": {
          "extension": "extension",
          "path": "path"
        },
        "urls": [
          {
            "type": "type",
            "url": "url"
          }
        ]
      }
    ],
    "total": 0
  },
  "etag": "etag",
  "status": "status"
}
```


**409** 

> Limit greater than 100.


[Back to API Reference](#api_reference)

