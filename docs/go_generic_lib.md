# Getting started

## How to Build


* In order to successfully build and run your SDK files, you are required to have the following setup in your system:
    * **Go**  (Visit [https://golang.org/doc/install](https://golang.org/doc/install) for more details on how to install Go)
    * **Java VM** Version 8 or later
    * **Eclipse 4.6 (Neon)** or later ([http://www.eclipse.org/neon/](http://www.eclipse.org/neon/))
    * **GoClipse** setup within above installed Eclipse (Follow the instructions at [this link](https://github.com/GoClipse/goclipse/blob/latest/documentation/Installation.md#instructions) to setup GoClipse)
* Ensure that ```GOPATH``` environment variable is set in the system variables. If not, set it to your workspace directory where you will be adding your Go projects.
* The generated code uses unirest-go http library. Therefore, you will need internet access to resolve this dependency. If Go is properly installed and configured, run the following command to pull the dependency:

```Go
go get github.com/apimatic/unirest-go
```

This will install unirest-go in the ```GOPATH``` you specified in the system variables.

Now follow the steps mentioned below to build your SDK:

1. Open eclipse in the Go language perspective and click on the ```Import``` option in ```File``` menu.

![Importing SDK into Eclipse - Step 1](https://apidocs.io/illustration/go?step=import0)

2. Select ```General -> Existing Projects into Workspace``` option from the tree list.

![Importing SDK into Eclipse - Step 2](https://apidocs.io/illustration/go?step=import1)

3. In ```Select root directory```, provide path to the unzipped archive for the generated code. Once the path is set and the Project becomes visible under ```Projects``` click ```Finish```

![Importing SDK into Eclipse - Step 3](https://apidocs.io/illustration/go?step=import2&workspaceFolder=MarvelComics-GoLang&projectName=marvelcomics_lib)

4. The Go library will be imported and its files will be visible in the Project Explorer

![Importing SDK into Eclipse - Step 4](https://apidocs.io/illustration/go?step=import3&projectName=marvelcomics_lib)

## How to Use

The following section explains how to use the MarvelcomicsLib library in a new project.

### 1. Add a new Test Project

Create a new project in Eclipse by ```File``` -> ```New``` -> ```Go Project```

![Add a new project in Eclipse](https://apidocs.io/illustration/go?step=createNewProject0)

Name the Project as ```Test``` and click ```Finish```

![Create a new Maven Project - Step 1](https://apidocs.io/illustration/go?step=createNewProject1)

Create a new directory in the ```src``` directory of this project

![Create a new Maven Project - Step 2](https://apidocs.io/illustration/go?step=createNewProject2&projectName=marvelcomics_lib)

Name it ```test.com```

![Create a new Maven Project - Step 3](https://apidocs.io/illustration/go?step=createNewProject3&projectName=marvelcomics_lib)

Now create a new file inside ```src/test.com```

![Create a new Maven Project - Step 4](https://apidocs.io/illustration/go?step=createNewProject4&projectName=marvelcomics_lib)

Name it ```testsdk.go```

![Create a new Maven Project - Step 5](https://apidocs.io/illustration/go?step=createNewProject5&projectName=marvelcomics_lib)

In this Go file, you can start adding code to initialize the client library. Sample code to initialize the client library and using its methods is given in the subsequent sections.

### 2. Configure the Test Project

You need to import your generated library in this project in order to make use of its functions. In order to import the library, you can add its path in the ```GOPATH``` for this project. Follow the below steps:

Right click on the project name and click on ```Properties```

![Adding dependency to the client library - Step 1](https://apidocs.io/illustration/go?step=testProject0&projectName=marvelcomics_lib)

Choose ```Go Compiler``` from the side menu. Check ```Use project specific settings``` and uncheck ```Use same value as the GOPATH environment variable.```. By default, the GOPATH value from the environment variables will be visible in ```Eclipse GOPATH```. Do not remove this as this points to the unirest dependency.

![Adding dependency to the client library - Step 2](https://apidocs.io/illustration/go?step=testProject1)

Append the library path to this GOPATH

![Adding dependency to the client library - Step 3](https://apidocs.io/illustration/go?step=testProject2&workspaceFolder=MarvelComics-GoLang)

Once the path is appended, click on ```OK```

### 3. Build the Test Project

Right click on the project name and click on ```Build Project```

![Build Project](https://apidocs.io/illustration/go?step=buildProject&projectName=marvelcomics_lib)

### 4. Run the Test Project

If the build is successful, right click on your Go file and click on ```Run As``` -> ```Go Application```

![Run Project](https://apidocs.io/illustration/go?step=runProject&projectName=marvelcomics_lib)

## Initialization

### Authentication
In order to setup authentication of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| referer | TODO: add a description |
| apikey | TODO: add a description |


To configure these for your generated code, open the file "Configuration.go" and edit it's contents.


# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [characters_pkg](#characters_pkg)
* [comics_pkg](#comics_pkg)
* [events_pkg](#events_pkg)
* [series_pkg](#series_pkg)
* [stories_pkg](#stories_pkg)
* [creators_pkg](#creators_pkg)

## <a name="characters_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".characters_pkg") characters_pkg

### Get instance

Factory for the ``` CHARACTERS ``` interface can be accessed from the package characters_pkg.

```go
characters := characters_pkg.NewCHARACTERS()
```

### <a name="get_character_individual"></a>![Method: ](https://apidocs.io/img/method.png ".characters_pkg.GetCharacterIndividual") GetCharacterIndividual

> Fetches a single character by id.


```go
func (me *CHARACTERS_IMPL) GetCharacterIndividual(characterId string)(*models_pkg.Character,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | A single character id. |


#### Example Usage

```go
characterId := "characterId"

var result *models_pkg.Character
result,_ = characters.GetCharacterIndividual(characterId)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 404 | Character not found. |



### <a name="get_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".characters_pkg.GetCharacterCollection") GetCharacterCollection

> Fetches lists of characters.


```go
func (me *CHARACTERS_IMPL) GetCharacterCollection(
            comics *string,
            events *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string)(*models_pkg.CharacterDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only characters which appear in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```go
comics := "comics"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
series := "series"
stories := "stories"

var result *models_pkg.CharacterDataWrapper
result,_ = characters.GetCharacterCollection(comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".characters_pkg.GetComicCharacterCollection") GetComicCharacterCollection

> Fetches lists of characters filtered by a comic id.


```go
func (me *CHARACTERS_IMPL) GetComicCharacterCollection(
            comicId string,
            events *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string)(*models_pkg.CharacterDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | The comic id. |
| events |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```go
comicId := "comicId"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
series := "series"
stories := "stories"

var result *models_pkg.CharacterDataWrapper
result,_ = characters.GetComicCharacterCollection(comicId, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".characters_pkg.GetEventCharacterCollection") GetEventCharacterCollection

> Fetches lists of characters filtered by an event id.


```go
func (me *CHARACTERS_IMPL) GetEventCharacterCollection(
            eventId string,
            comics *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string)(*models_pkg.CharacterDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The event ID |
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```go
eventId := "eventId"
comics := "comics"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
series := "series"
stories := "stories"

var result *models_pkg.CharacterDataWrapper
result,_ = characters.GetEventCharacterCollection(eventId, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_character_wrapper"></a>![Method: ](https://apidocs.io/img/method.png ".characters_pkg.GetSeriesCharacterWrapper") GetSeriesCharacterWrapper

> Fetches lists of characters filtered by a series id.


```go
func (me *CHARACTERS_IMPL) GetSeriesCharacterWrapper(
            seriesId string,
            comics *string,
            events *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            stories *string)(*models_pkg.CharacterDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series id. |
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```go
seriesId := "seriesId"
comics := "comics"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
stories := "stories"

var result *models_pkg.CharacterDataWrapper
result,_ = characters.GetSeriesCharacterWrapper(seriesId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_character_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".characters_pkg.GetCharacterCollectionByStoryId") GetCharacterCollectionByStoryId

> Fetches lists of characters filtered by a story id.


```go
func (me *CHARACTERS_IMPL) GetCharacterCollectionByStoryId(
            storyId string,
            comics *string,
            events *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string)(*models_pkg.CharacterDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| nameStartsWith |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```go
storyId := "storyId"
comics := "comics"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
series := "series"

var result *models_pkg.CharacterDataWrapper
result,_ = characters.GetCharacterCollectionByStoryId(storyId, comics, events, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="comics_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".comics_pkg") comics_pkg

### Get instance

Factory for the ``` COMICS ``` interface can be accessed from the package comics_pkg.

```go
comics := comics_pkg.NewCOMICS()
```

### <a name="get_comics_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".comics_pkg.GetComicsCharacterCollection") GetComicsCharacterCollection

> Fetches lists of comics filtered by a character id.


```go
func (me *COMICS_IMPL) GetComicsCharacterCollection(
            characterId string,
            collaborators *string,
            creators *string,
            dateDescriptor models_pkg.DateDescriptorEnum,
            dateRange *string,
            diamondCode *string,
            digitalId *string,
            ean *string,
            events *string,
            format *string,
            formatType models_pkg.FormatTypeEnum,
            hasDigitalIssue *string,
            isbn *string,
            issn *string,
            issueNumber *string,
            limit *string,
            modifiedSince *string,
            noVariants *string,
            offset *string,
            orderBy *string,
            series *string,
            sharedAppearances *string,
            startYear *string,
            stories *string,
            title *string,
            titleStartsWith *string,
            upc *string)(*models_pkg.ComicDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | The character id. |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```go
characterId := "characterId"
collaborators := "collaborators"
creators := "creators"
dateDescriptor := models_pkg.dateDescriptor_LASTWEEK
dateRange := "dateRange"
diamondCode := "diamondCode"
digitalId := "digitalId"
ean := "ean"
events := "events"
format := "comic"
formatType := models_pkg.formatType_COLLECTION
hasDigitalIssue := "true"
isbn := "isbn"
issn := "issn"
issueNumber := "issueNumber"
limit := "limit"
modifiedSince := "modifiedSince"
noVariants := "true"
offset := "offset"
orderBy := "focDate"
series := "series"
sharedAppearances := "sharedAppearances"
startYear := "startYear"
stories := "stories"
title := "title"
titleStartsWith := "titleStartsWith"
upc := "upc"

var result *models_pkg.ComicDataWrapper
result,_ = comics.GetComicsCharacterCollection(characterId, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection"></a>![Method: ](https://apidocs.io/img/method.png ".comics_pkg.GetComicsCollection") GetComicsCollection

> Fetches lists of comics.


```go
func (me *COMICS_IMPL) GetComicsCollection(
            characters *string,
            collaborators *string,
            creators *string,
            dateDescriptor models_pkg.DateDescriptorEnum,
            dateRange *string,
            diamondCode *string,
            digitalId *string,
            ean *string,
            events *string,
            format *string,
            formatType models_pkg.FormatTypeEnum,
            hasDigitalIssue *string,
            isbn *string,
            issn *string,
            issueNumber *string,
            limit *string,
            modifiedSince *string,
            noVariants *string,
            offset *string,
            orderBy *string,
            series *string,
            sharedAppearances *string,
            startYear *string,
            stories *string,
            title *string,
            titleStartsWith *string,
            upc *string)(*models_pkg.ComicDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). Accepts a comma-separated list of ids. |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variants (alternate covers, secondary printings, director's cuts, etc.) from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). Accepts a comma-separated list of ids. |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```go
characters := "characters"
collaborators := "collaborators"
creators := "creators"
dateDescriptor := models_pkg.dateDescriptor_LASTWEEK
dateRange := "dateRange"
diamondCode := "diamondCode"
digitalId := "digitalId"
ean := "ean"
events := "events"
format := "comic"
formatType := models_pkg.formatType_COLLECTION
hasDigitalIssue := "true"
isbn := "isbn"
issn := "issn"
issueNumber := "issueNumber"
limit := "limit"
modifiedSince := "modifiedSince"
noVariants := "true"
offset := "offset"
orderBy := "focDate"
series := "series"
sharedAppearances := "sharedAppearances"
startYear := "startYear"
stories := "stories"
title := "title"
titleStartsWith := "titleStartsWith"
upc := "upc"

var result *models_pkg.ComicDataWrapper
result,_ = comics.GetComicsCollection(characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_individual"></a>![Method: ](https://apidocs.io/img/method.png ".comics_pkg.GetComicIndividual") GetComicIndividual

> Fetches a single comic by id.


```go
func (me *COMICS_IMPL) GetComicIndividual(comicId string)(*models_pkg.Comic,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | A single comic. |


#### Example Usage

```go
comicId := "comicId"

var result *models_pkg.Comic
result,_ = comics.GetComicIndividual(comicId)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 404 | Comic not found. |



### <a name="get_comics_collection_by_creator_id"></a>![Method: ](https://apidocs.io/img/method.png ".comics_pkg.GetComicsCollectionByCreatorId") GetComicsCollectionByCreatorId

> Fetches lists of comics filtered by a creator id.


```go
func (me *COMICS_IMPL) GetComicsCollectionByCreatorId(
            creatorId string,
            characters *string,
            collaborators *string,
            dateDescriptor models_pkg.DateDescriptorEnum,
            dateRange *string,
            diamondCode *string,
            digitalId *string,
            ean *string,
            events *string,
            format *string,
            formatType models_pkg.FormatTypeEnum,
            hasDigitalIssue *string,
            isbn *string,
            issn *string,
            issueNumber *string,
            limit *string,
            modifiedSince *string,
            noVariants *string,
            offset *string,
            orderBy *string,
            series *string,
            sharedAppearances *string,
            startYear *string,
            stories *string,
            title *string,
            titleStartsWith *string,
            upc *string)(*models_pkg.ComicDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | The creator ID. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```go
creatorId := "creatorId"
characters := "characters"
collaborators := "collaborators"
dateDescriptor := models_pkg.dateDescriptor_LASTWEEK
dateRange := "dateRange"
diamondCode := "diamondCode"
digitalId := "digitalId"
ean := "ean"
events := "events"
format := "comic"
formatType := models_pkg.formatType_COLLECTION
hasDigitalIssue := "true"
isbn := "isbn"
issn := "issn"
issueNumber := "issueNumber"
limit := "limit"
modifiedSince := "modifiedSince"
noVariants := "true"
offset := "offset"
orderBy := "focDate"
series := "series"
sharedAppearances := "sharedAppearances"
startYear := "startYear"
stories := "stories"
title := "title"
titleStartsWith := "titleStartsWith"
upc := "upc"

var result *models_pkg.ComicDataWrapper
result,_ = comics.GetComicsCollectionByCreatorId(creatorId, characters, collaborators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".comics_pkg.GetComicsCollectionByEventId") GetComicsCollectionByEventId

> Fetches lists of comics filtered by an event id.


```go
func (me *COMICS_IMPL) GetComicsCollectionByEventId(
            eventId string,
            characters *string,
            collaborators *string,
            creators *string,
            dateDescriptor models_pkg.DateDescriptorEnum,
            dateRange *string,
            diamondCode *string,
            digitalId *string,
            ean *string,
            events *string,
            format *string,
            formatType models_pkg.FormatTypeEnum,
            hasDigitalIssue *string,
            isbn *string,
            issn *string,
            issueNumber *string,
            limit *string,
            modifiedSince *string,
            noVariants *string,
            offset *string,
            orderBy *string,
            series *string,
            sharedAppearances *string,
            startYear *string,
            stories *string,
            title *string,
            titleStartsWith *string,
            upc *string)(*models_pkg.ComicDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The event id. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```go
eventId := "eventId"
characters := "characters"
collaborators := "collaborators"
creators := "creators"
dateDescriptor := models_pkg.dateDescriptor_LASTWEEK
dateRange := "dateRange"
diamondCode := "diamondCode"
digitalId := "digitalId"
ean := "ean"
events := "events"
format := "comic"
formatType := models_pkg.formatType_COLLECTION
hasDigitalIssue := "true"
isbn := "isbn"
issn := "issn"
issueNumber := "issueNumber"
limit := "limit"
modifiedSince := "modifiedSince"
noVariants := "true"
offset := "offset"
orderBy := "focDate"
series := "series"
sharedAppearances := "sharedAppearances"
startYear := "startYear"
stories := "stories"
title := "title"
titleStartsWith := "titleStartsWith"
upc := "upc"

var result *models_pkg.ComicDataWrapper
result,_ = comics.GetComicsCollectionByEventId(eventId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, stories, title, titleStartsWith, upc)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".comics_pkg.GetComicsCollectionBySeriesId") GetComicsCollectionBySeriesId

> Fetches lists of comics filtered by a series id.


```go
func (me *COMICS_IMPL) GetComicsCollectionBySeriesId(
            seriesId string,
            characters *string,
            collaborators *string,
            creators *string,
            dateDescriptor models_pkg.DateDescriptorEnum,
            dateRange *string,
            diamondCode *string,
            digitalId *string,
            ean *string,
            events *string,
            format *string,
            formatType models_pkg.FormatTypeEnum,
            hasDigitalIssue *string,
            isbn *string,
            issn *string,
            issueNumber *string,
            limit *string,
            modifiedSince *string,
            noVariants *string,
            offset *string,
            orderBy *string,
            sharedAppearances *string,
            startYear *string,
            stories *string,
            title *string,
            titleStartsWith *string,
            upc *string)(*models_pkg.ComicDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series ID. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```go
seriesId := "seriesId"
characters := "characters"
collaborators := "collaborators"
creators := "creators"
dateDescriptor := models_pkg.dateDescriptor_LASTWEEK
dateRange := "dateRange"
diamondCode := "diamondCode"
digitalId := "digitalId"
ean := "ean"
events := "events"
format := "comic"
formatType := models_pkg.formatType_COLLECTION
hasDigitalIssue := "true"
isbn := "isbn"
issn := "issn"
issueNumber := "issueNumber"
limit := "limit"
modifiedSince := "modifiedSince"
noVariants := "true"
offset := "offset"
orderBy := "focDate"
sharedAppearances := "sharedAppearances"
startYear := "startYear"
stories := "stories"
title := "title"
titleStartsWith := "titleStartsWith"
upc := "upc"

var result *models_pkg.ComicDataWrapper
result,_ = comics.GetComicsCollectionBySeriesId(seriesId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, sharedAppearances, startYear, stories, title, titleStartsWith, upc)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".comics_pkg.GetComicsCollectionByStoryId") GetComicsCollectionByStoryId

> Fetches lists of comics filtered by a story id.


```go
func (me *COMICS_IMPL) GetComicsCollectionByStoryId(
            storyId string,
            characters *string,
            collaborators *string,
            creators *string,
            dateDescriptor models_pkg.DateDescriptorEnum,
            dateRange *string,
            diamondCode *string,
            digitalId *string,
            ean *string,
            events *string,
            format *string,
            formatType models_pkg.FormatTypeEnum,
            hasDigitalIssue *string,
            isbn *string,
            issn *string,
            issueNumber *string,
            limit *string,
            modifiedSince *string,
            noVariants *string,
            offset *string,
            orderBy *string,
            series *string,
            sharedAppearances *string,
            startYear *string,
            title *string,
            titleStartsWith *string,
            upc *string)(*models_pkg.ComicDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| dateDescriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| dateRange |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamondCode |  ``` Optional ```  | Filter by diamond code. |
| digitalId |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| formatType |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| hasDigitalIssue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issueNumber |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| noVariants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| sharedAppearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| startYear |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| titleStartsWith |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```go
storyId := "storyId"
characters := "characters"
collaborators := "collaborators"
creators := "creators"
dateDescriptor := models_pkg.dateDescriptor_LASTWEEK
dateRange := "dateRange"
diamondCode := "diamondCode"
digitalId := "digitalId"
ean := "ean"
events := "events"
format := "comic"
formatType := models_pkg.formatType_COLLECTION
hasDigitalIssue := "true"
isbn := "isbn"
issn := "issn"
issueNumber := "issueNumber"
limit := "limit"
modifiedSince := "modifiedSince"
noVariants := "true"
offset := "offset"
orderBy := "focDate"
series := "series"
sharedAppearances := "sharedAppearances"
startYear := "startYear"
title := "title"
titleStartsWith := "titleStartsWith"
upc := "upc"

var result *models_pkg.ComicDataWrapper
result,_ = comics.GetComicsCollectionByStoryId(storyId, characters, collaborators, creators, dateDescriptor, dateRange, diamondCode, digitalId, ean, events, format, formatType, hasDigitalIssue, isbn, issn, issueNumber, limit, modifiedSince, noVariants, offset, orderBy, series, sharedAppearances, startYear, title, titleStartsWith, upc)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="events_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".events_pkg") events_pkg

### Get instance

Factory for the ``` EVENTS ``` interface can be accessed from the package events_pkg.

```go
events := events_pkg.NewEVENTS()
```

### <a name="get_character_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".events_pkg.GetCharacterEventsCollection") GetCharacterEventsCollection

> Fetches lists of events filtered by a character id.


```go
func (me *EVENTS_IMPL) GetCharacterEventsCollection(
            characterId string,
            comics *string,
            creators *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string)(*models_pkg.EventDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | The character ID. |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```go
characterId := "characterId"
comics := "comics"
creators := "creators"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
series := "series"
stories := "stories"

var result *models_pkg.EventDataWrapper
result,_ = events.GetCharacterEventsCollection(characterId, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_issue_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".events_pkg.GetIssueEventsCollection") GetIssueEventsCollection

> Fetches lists of events filtered by a comic id.


```go
func (me *EVENTS_IMPL) GetIssueEventsCollection(
            comicId string,
            characters *string,
            creators *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string)(*models_pkg.EventDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | The comic ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```go
comicId := "comicId"
characters := "characters"
creators := "creators"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
series := "series"
stories := "stories"

var result *models_pkg.EventDataWrapper
result,_ = events.GetIssueEventsCollection(comicId, characters, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".events_pkg.GetCreatorEventsCollection") GetCreatorEventsCollection

> Fetches lists of events filtered by a creator id.


```go
func (me *EVENTS_IMPL) GetCreatorEventsCollection(
            creatorId string,
            characters *string,
            comics *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string)(*models_pkg.EventDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | The creator ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```go
creatorId := "creatorId"
characters := "characters"
comics := "comics"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
series := "series"
stories := "stories"

var result *models_pkg.EventDataWrapper
result,_ = events.GetCreatorEventsCollection(creatorId, characters, comics, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_individual"></a>![Method: ](https://apidocs.io/img/method.png ".events_pkg.GetEventIndividual") GetEventIndividual

> Fetches a single event by id.


```go
func (me *EVENTS_IMPL) GetEventIndividual(eventId string)(*models_pkg.Event,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | A single event. |


#### Example Usage

```go
eventId := "eventId"

var result *models_pkg.Event
result,_ = events.GetEventIndividual(eventId)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 404 | Event not found. |



### <a name="get_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".events_pkg.GetEventsCollection") GetEventsCollection

> Fetches lists of events.


```go
func (me *EVENTS_IMPL) GetEventsCollection(
            characters *string,
            comics *string,
            creators *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string)(*models_pkg.EventDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only events which match the specified name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which take place in the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```go
characters := "characters"
comics := "comics"
creators := "creators"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
series := "series"
stories := "stories"

var result *models_pkg.EventDataWrapper
result,_ = events.GetEventsCollection(characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series, stories)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_events_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".events_pkg.GetEventsCollectionBySeriesId") GetEventsCollectionBySeriesId

> Fetches lists of events filtered by a series id.


```go
func (me *EVENTS_IMPL) GetEventsCollectionBySeriesId(
            seriesId string,
            characters *string,
            comics *string,
            creators *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            stories *string)(*models_pkg.EventDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```go
seriesId := "seriesId"
characters := "characters"
comics := "comics"
creators := "creators"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
stories := "stories"

var result *models_pkg.EventDataWrapper
result,_ = events.GetEventsCollectionBySeriesId(seriesId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, stories)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_events_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".events_pkg.GetEventsCollectionByStoryId") GetEventsCollectionByStoryId

> Fetches lists of events filtered by a story id.


```go
func (me *EVENTS_IMPL) GetEventsCollectionByStoryId(
            storyId string,
            characters *string,
            comics *string,
            creators *string,
            limit *string,
            modifiedSince *string,
            name *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string)(*models_pkg.EventDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| nameStartsWith |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```go
storyId := "storyId"
characters := "characters"
comics := "comics"
creators := "creators"
limit := "limit"
modifiedSince := "modifiedSince"
name := "name"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "name"
series := "series"

var result *models_pkg.EventDataWrapper
result,_ = events.GetEventsCollectionByStoryId(storyId, characters, comics, creators, limit, modifiedSince, name, nameStartsWith, offset, orderBy, series)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="series_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".series_pkg") series_pkg

### Get instance

Factory for the ``` SERIES ``` interface can be accessed from the package series_pkg.

```go
series := series_pkg.NewSERIES()
```

### <a name="get_character_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".series_pkg.GetCharacterSeriesCollection") GetCharacterSeriesCollection

> Fetches lists of series filtered by a character id.


```go
func (me *SERIES_IMPL) GetCharacterSeriesCollection(
            characterId string,
            comics *string,
            contains *string,
            creators *string,
            events *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            seriesType *string,
            startYear *string,
            stories *string,
            title *string,
            titleStartsWith *string)(*models_pkg.SeriesDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | The character ID |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Filter by series title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```go
characterId := "characterId"
comics := "comics"
contains := "comic"
creators := "creators"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "title"
seriesType := "collection"
startYear := "startYear"
stories := "stories"
title := "title"
titleStartsWith := "titleStartsWith"

var result *models_pkg.SeriesDataWrapper
result,_ = series.GetCharacterSeriesCollection(characterId, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_individual"></a>![Method: ](https://apidocs.io/img/method.png ".series_pkg.GetSeriesIndividual") GetSeriesIndividual

> Fetches a single comic series by id.


```go
func (me *SERIES_IMPL) GetSeriesIndividual(seriesId string)(*models_pkg.Series,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | Filter by series title. |


#### Example Usage

```go
seriesId := "seriesId"

var result *models_pkg.Series
result,_ = series.GetSeriesIndividual(seriesId)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 404 | Series not found. |



### <a name="get_creator_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".series_pkg.GetCreatorSeriesCollection") GetCreatorSeriesCollection

> Fetches lists of series filtered by a creator id.


```go
func (me *SERIES_IMPL) GetCreatorSeriesCollection(
            creatorId string,
            characters *string,
            comics *string,
            contains *string,
            events *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            seriesType *string,
            startYear *string,
            stories *string,
            title *string,
            titleStartsWith *string)(*models_pkg.SeriesDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | The creator ID. |
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Filter by series title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```go
creatorId := "creatorId"
characters := "characters"
comics := "comics"
contains := "comic"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "title"
seriesType := "collection"
startYear := "startYear"
stories := "stories"
title := "title"
titleStartsWith := "titleStartsWith"

var result *models_pkg.SeriesDataWrapper
result,_ = series.GetCreatorSeriesCollection(creatorId, characters, comics, contains, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".series_pkg.GetEventSeriesCollection") GetEventSeriesCollection

> Fetches lists of series filtered by an event id.


```go
func (me *SERIES_IMPL) GetEventSeriesCollection(
            eventId string,
            characters *string,
            comics *string,
            contains *string,
            creators *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            seriesType *string,
            startYear *string,
            stories *string,
            title *string,
            titleStartsWith *string)(*models_pkg.SeriesDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The event ID. |
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Filter by series title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```go
eventId := "eventId"
characters := "characters"
comics := "comics"
contains := "comic"
creators := "creators"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "title"
seriesType := "collection"
startYear := "startYear"
stories := "stories"
title := "title"
titleStartsWith := "titleStartsWith"

var result *models_pkg.SeriesDataWrapper
result,_ = series.GetEventSeriesCollection(eventId, characters, comics, contains, creators, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".series_pkg.GetSeriesCollection") GetSeriesCollection

> Fetches lists of series.


```go
func (me *SERIES_IMPL) GetSeriesCollection(
            characters *string,
            comics *string,
            contains *string,
            creators *string,
            events *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            seriesType *string,
            startYear *string,
            stories *string,
            title *string,
            titleStartsWith *string)(*models_pkg.SeriesDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only series matching the specified title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```go
characters := "characters"
comics := "comics"
contains := "comic"
creators := "creators"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "title"
seriesType := "collection"
startYear := "startYear"
stories := "stories"
title := "title"
titleStartsWith := "titleStartsWith"

var result *models_pkg.SeriesDataWrapper
result,_ = series.GetSeriesCollection(characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, stories, title, titleStartsWith)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".series_pkg.GetStorySeriesCollection") GetStorySeriesCollection

> Fetches lists of series filtered by a story id.


```go
func (me *SERIES_IMPL) GetStorySeriesCollection(
            storyId string,
            characters *string,
            comics *string,
            contains *string,
            creators *string,
            events *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            seriesType *string,
            startYear *string,
            title *string,
            titleStartsWith *string)(*models_pkg.SeriesDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| seriesType |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| startYear |  ``` Optional ```  | Return only series matching the specified start year. |
| title |  ``` Optional ```  | Filter by series title. |
| titleStartsWith |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```go
storyId := "storyId"
characters := "characters"
comics := "comics"
contains := "comic"
creators := "creators"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "title"
seriesType := "collection"
startYear := "startYear"
title := "title"
titleStartsWith := "titleStartsWith"

var result *models_pkg.SeriesDataWrapper
result,_ = series.GetStorySeriesCollection(storyId, characters, comics, contains, creators, events, limit, modifiedSince, offset, orderBy, seriesType, startYear, title, titleStartsWith)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="stories_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".stories_pkg") stories_pkg

### Get instance

Factory for the ``` STORIES ``` interface can be accessed from the package stories_pkg.

```go
stories := stories_pkg.NewSTORIES()
```

### <a name="get_character_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".stories_pkg.GetCharacterStoryCollection") GetCharacterStoryCollection

> Fetches lists of stories filtered by a character id.


```go
func (me *STORIES_IMPL) GetCharacterStoryCollection(
            characterId string,
            comics *string,
            creators *string,
            events *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            series *string)(*models_pkg.StoryDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | The character ID. |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```go
characterId := "characterId"
comics := "comics"
creators := "creators"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "id"
series := "series"

var result *models_pkg.StoryDataWrapper
result,_ = stories.GetCharacterStoryCollection(characterId, comics, creators, events, limit, modifiedSince, offset, orderBy, series)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_story_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".stories_pkg.GetComicStoryCollectionByComicId") GetComicStoryCollectionByComicId

> Fetches lists of stories filtered by a comic id.


```go
func (me *STORIES_IMPL) GetComicStoryCollectionByComicId(
            comicId string,
            characters *string,
            creators *string,
            events *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            series *string)(*models_pkg.StoryDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | The comic ID. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```go
comicId := "comicId"
characters := "characters"
creators := "creators"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "id"
series := "series"

var result *models_pkg.StoryDataWrapper
result,_ = stories.GetComicStoryCollectionByComicId(comicId, characters, creators, events, limit, modifiedSince, offset, orderBy, series)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".stories_pkg.GetCreatorStoryCollection") GetCreatorStoryCollection

> Fetches lists of stories filtered by a creator id.


```go
func (me *STORIES_IMPL) GetCreatorStoryCollection(
            creatorId string,
            characters *string,
            comics *string,
            events *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            series *string)(*models_pkg.StoryDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | The ID of the creator. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```go
creatorId := "creatorId"
characters := "characters"
comics := "comics"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "id"
series := "series"

var result *models_pkg.StoryDataWrapper
result,_ = stories.GetCreatorStoryCollection(creatorId, characters, comics, events, limit, modifiedSince, offset, orderBy, series)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_individual"></a>![Method: ](https://apidocs.io/img/method.png ".stories_pkg.GetStoryIndividual") GetStoryIndividual

> Fetches a single comic story by id.


```go
func (me *STORIES_IMPL) GetStoryIndividual(storyId string)(*models_pkg.Story,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | Filter by story id. |


#### Example Usage

```go
storyId := "storyId"

var result *models_pkg.Story
result,_ = stories.GetStoryIndividual(storyId)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 404 | Story not found. |



### <a name="get_event_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".stories_pkg.GetEventStoryCollection") GetEventStoryCollection

> Fetches lists of stories filtered by an event id.


```go
func (me *STORIES_IMPL) GetEventStoryCollection(
            eventId string,
            characters *string,
            comics *string,
            creators *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            series *string)(*models_pkg.StoryDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The ID of the event. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```go
eventId := "eventId"
characters := "characters"
comics := "comics"
creators := "creators"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "id"
series := "series"

var result *models_pkg.StoryDataWrapper
result,_ = stories.GetEventStoryCollection(eventId, characters, comics, creators, limit, modifiedSince, offset, orderBy, series)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".stories_pkg.GetSeriesStoryCollection") GetSeriesStoryCollection

> Fetches lists of stories filtered by a series id.


```go
func (me *STORIES_IMPL) GetSeriesStoryCollection(
            seriesId string,
            characters *string,
            comics *string,
            creators *string,
            events *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string)(*models_pkg.StoryDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series ID. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |


#### Example Usage

```go
seriesId := "seriesId"
characters := "characters"
comics := "comics"
creators := "creators"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "id"

var result *models_pkg.StoryDataWrapper
result,_ = stories.GetSeriesStoryCollection(seriesId, characters, comics, creators, events, limit, modifiedSince, offset, orderBy)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".stories_pkg.GetStoryCollection") GetStoryCollection

> Fetches lists of stories.


```go
func (me *STORIES_IMPL) GetStoryCollection(
            characters *string,
            comics *string,
            creators *string,
            events *string,
            limit *string,
            modifiedSince *string,
            offset *string,
            orderBy *string,
            series *string)(*models_pkg.StoryDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modifiedSince |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```go
characters := "characters"
comics := "comics"
creators := "creators"
events := "events"
limit := "limit"
modifiedSince := "modifiedSince"
offset := "offset"
orderBy := "id"
series := "series"

var result *models_pkg.StoryDataWrapper
result,_ = stories.GetStoryCollection(characters, comics, creators, events, limit, modifiedSince, offset, orderBy, series)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="creators_pkg"></a>![Class: ](https://apidocs.io/img/class.png ".creators_pkg") creators_pkg

### Get instance

Factory for the ``` CREATORS ``` interface can be accessed from the package creators_pkg.

```go
creators := creators_pkg.NewCREATORS()
```

### <a name="get_creator_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".creators_pkg.GetCreatorCollectionByComicId") GetCreatorCollectionByComicId

> Fetches lists of creators filtered by a comic id.


```go
func (me *CREATORS_IMPL) GetCreatorCollectionByComicId(
            comicId string,
            comics *string,
            firstName *string,
            firstNameStartsWith *string,
            lastName *string,
            lastNameStartsWith *string,
            limit *string,
            middleName *string,
            middleNameStartsWith *string,
            modifiedSince *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string,
            suffix *string)(*models_pkg.CreatorDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | The comic id. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```go
comicId := "comicId"
comics := "comics"
firstName := "firstName"
firstNameStartsWith := "firstNameStartsWith"
lastName := "lastName"
lastNameStartsWith := "lastNameStartsWith"
limit := "limit"
middleName := "middleName"
middleNameStartsWith := "middleNameStartsWith"
modifiedSince := "modifiedSince"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "lastName"
series := "series"
stories := "stories"
suffix := "suffix"

var result *models_pkg.CreatorDataWrapper
result,_ = creators.GetCreatorCollectionByComicId(comicId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection"></a>![Method: ](https://apidocs.io/img/method.png ".creators_pkg.GetCreatorCollection") GetCreatorCollection

> Fetches lists of creators.


```go
func (me *CREATORS_IMPL) GetCreatorCollection(
            comics *string,
            events *string,
            firstName *string,
            firstNameStartsWith *string,
            lastName *string,
            lastNameStartsWith *string,
            limit *string,
            middleName *string,
            middleNameStartsWith *string,
            modifiedSince *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string,
            suffix *string)(*models_pkg.CreatorDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. Brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```go
comics := "comics"
events := "events"
firstName := "firstName"
firstNameStartsWith := "firstNameStartsWith"
lastName := "lastName"
lastNameStartsWith := "lastNameStartsWith"
limit := "limit"
middleName := "middleName"
middleNameStartsWith := "middleNameStartsWith"
modifiedSince := "modifiedSince"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "lastName"
series := "series"
stories := "stories"
suffix := "suffix"

var result *models_pkg.CreatorDataWrapper
result,_ = creators.GetCreatorCollection(comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_individual"></a>![Method: ](https://apidocs.io/img/method.png ".creators_pkg.GetCreatorIndividual") GetCreatorIndividual

> Fetches a single creator by id.


```go
func (me *CREATORS_IMPL) GetCreatorIndividual(creatorId string)(*models_pkg.Creator,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | A single creator id. |


#### Example Usage

```go
creatorId := "creatorId"

var result *models_pkg.Creator
result,_ = creators.GetCreatorIndividual(creatorId)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 404 | Creator not found. |



### <a name="get_creator_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".creators_pkg.GetCreatorCollectionByEventId") GetCreatorCollectionByEventId

> Fetches lists of creators filtered by an event id.


```go
func (me *CREATORS_IMPL) GetCreatorCollectionByEventId(
            eventId string,
            comics *string,
            firstName *string,
            firstNameStartsWith *string,
            lastName *string,
            lastNameStartsWith *string,
            limit *string,
            middleName *string,
            middleNameStartsWith *string,
            modifiedSince *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            stories *string,
            suffix *string)(*models_pkg.CreatorDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | The event ID. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```go
eventId := "eventId"
comics := "comics"
firstName := "firstName"
firstNameStartsWith := "firstNameStartsWith"
lastName := "lastName"
lastNameStartsWith := "lastNameStartsWith"
limit := "limit"
middleName := "middleName"
middleNameStartsWith := "middleNameStartsWith"
modifiedSince := "modifiedSince"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "lastName"
series := "series"
stories := "stories"
suffix := "suffix"

var result *models_pkg.CreatorDataWrapper
result,_ = creators.GetCreatorCollectionByEventId(eventId, comics, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, stories, suffix)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".creators_pkg.GetCreatorCollectionBySeriesId") GetCreatorCollectionBySeriesId

> Fetches lists of creators filtered by a series id.


```go
func (me *CREATORS_IMPL) GetCreatorCollectionBySeriesId(
            seriesId string,
            comics *string,
            events *string,
            firstName *string,
            firstNameStartsWith *string,
            lastName *string,
            lastNameStartsWith *string,
            limit *string,
            middleName *string,
            middleNameStartsWith *string,
            modifiedSince *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            stories *string,
            suffix *string)(*models_pkg.CreatorDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | The series ID. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```go
seriesId := "seriesId"
comics := "comics"
events := "events"
firstName := "firstName"
firstNameStartsWith := "firstNameStartsWith"
lastName := "lastName"
lastNameStartsWith := "lastNameStartsWith"
limit := "limit"
middleName := "middleName"
middleNameStartsWith := "middleNameStartsWith"
modifiedSince := "modifiedSince"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "lastName"
stories := "stories"
suffix := "suffix"

var result *models_pkg.CreatorDataWrapper
result,_ = creators.GetCreatorCollectionBySeriesId(seriesId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, stories, suffix)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".creators_pkg.GetCreatorCollectionByStoryId") GetCreatorCollectionByStoryId

> Fetches lists of creators filtered by a story id.


```go
func (me *CREATORS_IMPL) GetCreatorCollectionByStoryId(
            storyId string,
            comics *string,
            events *string,
            firstName *string,
            firstNameStartsWith *string,
            lastName *string,
            lastNameStartsWith *string,
            limit *string,
            middleName *string,
            middleNameStartsWith *string,
            modifiedSince *string,
            nameStartsWith *string,
            offset *string,
            orderBy *string,
            series *string,
            suffix *string)(*models_pkg.CreatorDataWrapper,error)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | The story ID. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). |
| firstName |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| firstNameStartsWith |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| lastName |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| lastNameStartsWith |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middleName |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middleNameStartsWith |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modifiedSince |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| nameStartsWith |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| orderBy |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```go
storyId := "storyId"
comics := "comics"
events := "events"
firstName := "firstName"
firstNameStartsWith := "firstNameStartsWith"
lastName := "lastName"
lastNameStartsWith := "lastNameStartsWith"
limit := "limit"
middleName := "middleName"
middleNameStartsWith := "middleNameStartsWith"
modifiedSince := "modifiedSince"
nameStartsWith := "nameStartsWith"
offset := "offset"
orderBy := "lastName"
series := "series"
suffix := "suffix"

var result *models_pkg.CreatorDataWrapper
result,_ = creators.GetCreatorCollectionByStoryId(storyId, comics, events, firstName, firstNameStartsWith, lastName, lastNameStartsWith, limit, middleName, middleNameStartsWith, modifiedSince, nameStartsWith, offset, orderBy, series, suffix)

```

#### Errors
 
| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)



