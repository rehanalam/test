# Getting started

## How to Build

This client library is a Ruby gem which can be compiled and used in your Ruby and Ruby on Rails project. This library requires a few gems from the RubyGems repository.

1. Open the command line interface or the terminal and navigate to the folder containing the source code.
2. Run ``` gem build marvel_comics.gemspec ``` to build the gem.
3. Once built, the gem can be installed on the current work environment using ``` gem install marvel_comics-1.0.0.gem ```

![Building Gem](https://apidocs.io/illustration/ruby?step=buildSDK&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics-Ruby&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0)

## How to Use

The following section explains how to use the MarvelComics Ruby Gem in a new Rails project using RubyMine&trade;. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.

### 1. Starting a new project

Close any existing projects in RubyMine&trade; by selecting ``` File -> Close Project ```. Next, click on ``` Create New Project ``` to create a new project from scratch.

![Create a new project in RubyMine](https://apidocs.io/illustration/ruby?step=createNewProject0&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0)

Next, provide ``` TestApp ``` as the project name, choose ``` Rails Application ``` as the project type, and click ``` OK ```.

![Create a new Rails Application in RubyMine - step 1](https://apidocs.io/illustration/ruby?step=createNewProject1&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0)

In the next dialog make sure that correct *Ruby SDK* is being used (minimum 2.0.0) and click ``` OK ```.

![Create a new Rails Application in RubyMine - step 2](https://apidocs.io/illustration/ruby?step=createNewProject2&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0)

This will create a new Rails Application project with an existing set of files and folder.

### 2. Add reference of the gem

In order to use the MarvelComics gem in the new project we must add a gem reference. Locate the ```Gemfile``` in the *Project Explorer* window under the ``` TestApp ``` project node. The file contains references to all gems being used in the project. Here, add the reference to the library gem by adding the following line: ``` gem 'marvel_comics', '~> 1.0.0' ```

![Add references of the Gemfile](https://apidocs.io/illustration/ruby?step=addReference&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0)

### 3. Adding a new Rails Controller

Once the ``` TestApp ``` project is created, a folder named ``` controllers ``` will be visible in the *Project Explorer* under the following path: ``` TestApp > app > controllers ```. Right click on this folder and select ``` New -> Run Rails Generator... ```.

![Run Rails Generator on Controllers Folder](https://apidocs.io/illustration/ruby?step=addCode0&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0)

Selecting the said option will popup a small window where the generator names are displayed. Here, select the ``` controller ``` template.

![Create a new Controller](https://apidocs.io/illustration/ruby?step=addCode1&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0)

Next, a popup window will ask you for a Controller name and included Actions. For controller name provide ``` Hello ``` and include an action named ``` Index ``` and click ``` OK ```.

![Add a new Controller](https://apidocs.io/illustration/ruby?step=addCode2&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0)

A new controller class anmed ``` HelloController ``` will be created in a file named ``` hello_controller.rb ``` containing a method named ``` Index ```. In this method, add code for initialization and a sample for its usage.

![Initialize the library](https://apidocs.io/illustration/ruby?step=addCode3&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0)

## How to Test

You can test the generated SDK and the server with automatically generated test
cases as follows:

  1. From terminal/cmd navigate to the root directory of the SDK.
  2. Invoke: `bundle exec rake`

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| referer | TODO: add a description |
| apikey | TODO: add a description |



API client can be initialized as following.

```ruby
# Configuration parameters and credentials
referer = "*.marvel.com";
apikey = "apikey";

client = MarvelComics::MarvelComicsClient.new(referer: referer, apikey: apikey)
```

The added initlization code can be debugged by putting a breakpoint in the ``` Index ``` method and running the project in debug mode by selecting ``` Run -> Debug 'Development: TestApp' ```.

![Debug the TestApp](https://apidocs.io/illustration/ruby?step=addCode4&workspaceFolder=MarvelComics-Ruby&workspaceName=MarvelComics&projectName=marvel_comics&gemName=marvel_comics&gemVer=1.0.0&initLine=client%2520%253D%2520MarvelComicsClient.new%2528%2527referer%2527%252C%2520%2527apikey%2527%2529)

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [CharactersController](#characters_controller)
* [ComicsController](#comics_controller)
* [EventsController](#events_controller)
* [SeriesController](#series_controller)
* [StoriesController](#stories_controller)
* [CreatorsController](#creators_controller)

## <a name="characters_controller"></a>![Class: ](https://apidocs.io/img/class.png ".CharactersController") CharactersController

### Get singleton instance

The singleton instance of the ``` CharactersController ``` class can be accessed from the API Client.

```ruby
characters = client.characters
```

### <a name="get_character_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_character_individual") get_character_individual

> Fetches a single character by id.


```ruby
def get_character_individual(character_id); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| character_id |  ``` Required ```  | A single character id. |


#### Example Usage

```ruby
character_id = 'characterId'

result = characters.get_character_individual(character_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Character not found. |



### <a name="get_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_character_collection") get_character_collection

> Fetches lists of characters.


```ruby
def get_character_collection(comics = nil, 
                                 events = nil, 
                                 limit = nil, 
                                 modified_since = nil, 
                                 name = nil, 
                                 name_starts_with = nil, 
                                 offset = nil, 
                                 order_by = 'name', 
                                 series = nil, 
                                 stories = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only characters which appear in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| name_starts_with |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
comics = 'comics'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
series = 'series'
stories = 'stories'

result = characters.get_character_collection(comics, events, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_comic_character_collection") get_comic_character_collection

> Fetches lists of characters filtered by a comic id.


```ruby
def get_comic_character_collection(comic_id, 
                                       events = nil, 
                                       limit = nil, 
                                       modified_since = nil, 
                                       name = nil, 
                                       name_starts_with = nil, 
                                       offset = nil, 
                                       order_by = 'name', 
                                       series = nil, 
                                       stories = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comic_id |  ``` Required ```  | The comic id. |
| events |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| name_starts_with |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
comic_id = 'comicId'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
series = 'series'
stories = 'stories'

result = characters.get_comic_character_collection(comic_id, events, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_event_character_collection") get_event_character_collection

> Fetches lists of characters filtered by an event id.


```ruby
def get_event_character_collection(event_id, 
                                       comics = nil, 
                                       limit = nil, 
                                       modified_since = nil, 
                                       name = nil, 
                                       name_starts_with = nil, 
                                       offset = nil, 
                                       order_by = 'name', 
                                       series = nil, 
                                       stories = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| event_id |  ``` Required ```  | The event ID |
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| name_starts_with |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
event_id = 'eventId'
comics = 'comics'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
series = 'series'
stories = 'stories'

result = characters.get_event_character_collection(event_id, comics, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_character_wrapper"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_series_character_wrapper") get_series_character_wrapper

> Fetches lists of characters filtered by a series id.


```ruby
def get_series_character_wrapper(series_id, 
                                     comics = nil, 
                                     events = nil, 
                                     limit = nil, 
                                     modified_since = nil, 
                                     name = nil, 
                                     name_starts_with = nil, 
                                     offset = nil, 
                                     order_by = 'name', 
                                     stories = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| series_id |  ``` Required ```  | The series id. |
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| name_starts_with |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| stories |  ``` Optional ```  | Return only characters which appear the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
series_id = 'seriesId'
comics = 'comics'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
stories = 'stories'

result = characters.get_series_character_wrapper(series_id, comics, events, limit, modified_since, name, name_starts_with, offset, order_by, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_character_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_character_collection_by_story_id") get_character_collection_by_story_id

> Fetches lists of characters filtered by a story id.


```ruby
def get_character_collection_by_story_id(story_id, 
                                             comics = nil, 
                                             events = nil, 
                                             limit = nil, 
                                             modified_since = nil, 
                                             name = nil, 
                                             name_starts_with = nil, 
                                             offset = nil, 
                                             order_by = 'name', 
                                             series = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| story_id |  ``` Required ```  | The story ID. |
| comics |  ``` Optional ```  | Return only characters which appear in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only characters which appear comics that took place in the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only characters which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only characters matching the specified full character name (e.g. Spider-Man). |
| name_starts_with |  ``` Optional ```  | Return characters with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "modified", "-name", "-modified") |
| series |  ``` Optional ```  | Return only characters which appear the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
story_id = 'storyId'
comics = 'comics'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
series = 'series'

result = characters.get_character_collection_by_story_id(story_id, comics, events, limit, modified_since, name, name_starts_with, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="comics_controller"></a>![Class: ](https://apidocs.io/img/class.png ".ComicsController") ComicsController

### Get singleton instance

The singleton instance of the ``` ComicsController ``` class can be accessed from the API Client.

```ruby
comics = client.comics
```

### <a name="get_comics_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_character_collection") get_comics_character_collection

> Fetches lists of comics filtered by a character id.


```ruby
def get_comics_character_collection(character_id, 
                                        collaborators = nil, 
                                        creators = nil, 
                                        date_descriptor = nil, 
                                        date_range = nil, 
                                        diamond_code = nil, 
                                        digital_id = nil, 
                                        ean = nil, 
                                        events = nil, 
                                        format = 'comic', 
                                        format_type = nil, 
                                        has_digital_issue = 'true', 
                                        isbn = nil, 
                                        issn = nil, 
                                        issue_number = nil, 
                                        limit = nil, 
                                        modified_since = nil, 
                                        no_variants = 'true', 
                                        offset = nil, 
                                        order_by = 'focDate', 
                                        series = nil, 
                                        shared_appearances = nil, 
                                        start_year = nil, 
                                        stories = nil, 
                                        title = nil, 
                                        title_starts_with = nil, 
                                        upc = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| character_id |  ``` Required ```  | The character id. |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| date_descriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| date_range |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamond_code |  ``` Optional ```  | Filter by diamond code. |
| digital_id |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| format_type |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| has_digital_issue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issue_number |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| no_variants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| shared_appearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| start_year |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| title_starts_with |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```ruby
character_id = 'characterId'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = MarvelComics::DateDescriptorEnum::LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = MarvelComics::FormatTypeEnum::COLLECTION
has_digital_issue = 'true'
isbn = 'isbn'
issn = 'issn'
issue_number = 'issueNumber'
limit = 'limit'
modified_since = 'modifiedSince'
no_variants = 'true'
offset = 'offset'
order_by = 'focDate'
series = 'series'
shared_appearances = 'sharedAppearances'
start_year = 'startYear'
stories = 'stories'
title = 'title'
title_starts_with = 'titleStartsWith'
upc = 'upc'

result = comics.get_comics_character_collection(character_id, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection") get_comics_collection

> Fetches lists of comics.


```ruby
def get_comics_collection(characters = nil, 
                              collaborators = nil, 
                              creators = nil, 
                              date_descriptor = nil, 
                              date_range = nil, 
                              diamond_code = nil, 
                              digital_id = nil, 
                              ean = nil, 
                              events = nil, 
                              format = 'comic', 
                              format_type = nil, 
                              has_digital_issue = 'true', 
                              isbn = nil, 
                              issn = nil, 
                              issue_number = nil, 
                              limit = nil, 
                              modified_since = nil, 
                              no_variants = 'true', 
                              offset = nil, 
                              order_by = 'focDate', 
                              series = nil, 
                              shared_appearances = nil, 
                              start_year = nil, 
                              stories = nil, 
                              title = nil, 
                              title_starts_with = nil, 
                              upc = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). Accepts a comma-separated list of ids. |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| date_descriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| date_range |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamond_code |  ``` Optional ```  | Filter by diamond code. |
| digital_id |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| format_type |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| has_digital_issue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issue_number |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| no_variants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variants (alternate covers, secondary printings, director's cuts, etc.) from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| shared_appearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). Accepts a comma-separated list of ids. |
| start_year |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| title_starts_with |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```ruby
characters = 'characters'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = MarvelComics::DateDescriptorEnum::LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = MarvelComics::FormatTypeEnum::COLLECTION
has_digital_issue = 'true'
isbn = 'isbn'
issn = 'issn'
issue_number = 'issueNumber'
limit = 'limit'
modified_since = 'modifiedSince'
no_variants = 'true'
offset = 'offset'
order_by = 'focDate'
series = 'series'
shared_appearances = 'sharedAppearances'
start_year = 'startYear'
stories = 'stories'
title = 'title'
title_starts_with = 'titleStartsWith'
upc = 'upc'

result = comics.get_comics_collection(characters, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_individual"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comic_individual") get_comic_individual

> Fetches a single comic by id.


```ruby
def get_comic_individual(comic_id); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comic_id |  ``` Required ```  | A single comic. |


#### Example Usage

```ruby
comic_id = 'comicId'

result = comics.get_comic_individual(comic_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Comic not found. |



### <a name="get_comics_collection_by_creator_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection_by_creator_id") get_comics_collection_by_creator_id

> Fetches lists of comics filtered by a creator id.


```ruby
def get_comics_collection_by_creator_id(creator_id, 
                                            characters = nil, 
                                            collaborators = nil, 
                                            date_descriptor = nil, 
                                            date_range = nil, 
                                            diamond_code = nil, 
                                            digital_id = nil, 
                                            ean = nil, 
                                            events = nil, 
                                            format = 'comic', 
                                            format_type = nil, 
                                            has_digital_issue = 'true', 
                                            isbn = nil, 
                                            issn = nil, 
                                            issue_number = nil, 
                                            limit = nil, 
                                            modified_since = nil, 
                                            no_variants = 'true', 
                                            offset = nil, 
                                            order_by = 'focDate', 
                                            series = nil, 
                                            shared_appearances = nil, 
                                            start_year = nil, 
                                            stories = nil, 
                                            title = nil, 
                                            title_starts_with = nil, 
                                            upc = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creator_id |  ``` Required ```  | The creator ID. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| date_descriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| date_range |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamond_code |  ``` Optional ```  | Filter by diamond code. |
| digital_id |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| format_type |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| has_digital_issue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issue_number |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| no_variants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| shared_appearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| start_year |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| title_starts_with |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```ruby
creator_id = 'creatorId'
characters = 'characters'
collaborators = 'collaborators'
date_descriptor = MarvelComics::DateDescriptorEnum::LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = MarvelComics::FormatTypeEnum::COLLECTION
has_digital_issue = 'true'
isbn = 'isbn'
issn = 'issn'
issue_number = 'issueNumber'
limit = 'limit'
modified_since = 'modifiedSince'
no_variants = 'true'
offset = 'offset'
order_by = 'focDate'
series = 'series'
shared_appearances = 'sharedAppearances'
start_year = 'startYear'
stories = 'stories'
title = 'title'
title_starts_with = 'titleStartsWith'
upc = 'upc'

result = comics.get_comics_collection_by_creator_id(creator_id, characters, collaborators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection_by_event_id") get_comics_collection_by_event_id

> Fetches lists of comics filtered by an event id.


```ruby
def get_comics_collection_by_event_id(event_id, 
                                          characters = nil, 
                                          collaborators = nil, 
                                          creators = nil, 
                                          date_descriptor = nil, 
                                          date_range = nil, 
                                          diamond_code = nil, 
                                          digital_id = nil, 
                                          ean = nil, 
                                          events = nil, 
                                          format = 'comic', 
                                          format_type = nil, 
                                          has_digital_issue = 'true', 
                                          isbn = nil, 
                                          issn = nil, 
                                          issue_number = nil, 
                                          limit = nil, 
                                          modified_since = nil, 
                                          no_variants = 'true', 
                                          offset = nil, 
                                          order_by = 'focDate', 
                                          series = nil, 
                                          shared_appearances = nil, 
                                          start_year = nil, 
                                          stories = nil, 
                                          title = nil, 
                                          title_starts_with = nil, 
                                          upc = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| event_id |  ``` Required ```  | The event id. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| date_descriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| date_range |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamond_code |  ``` Optional ```  | Filter by diamond code. |
| digital_id |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| format_type |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| has_digital_issue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issue_number |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| no_variants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| shared_appearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| start_year |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| title_starts_with |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```ruby
event_id = 'eventId'
characters = 'characters'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = MarvelComics::DateDescriptorEnum::LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = MarvelComics::FormatTypeEnum::COLLECTION
has_digital_issue = 'true'
isbn = 'isbn'
issn = 'issn'
issue_number = 'issueNumber'
limit = 'limit'
modified_since = 'modifiedSince'
no_variants = 'true'
offset = 'offset'
order_by = 'focDate'
series = 'series'
shared_appearances = 'sharedAppearances'
start_year = 'startYear'
stories = 'stories'
title = 'title'
title_starts_with = 'titleStartsWith'
upc = 'upc'

result = comics.get_comics_collection_by_event_id(event_id, characters, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection_by_series_id") get_comics_collection_by_series_id

> Fetches lists of comics filtered by a series id.


```ruby
def get_comics_collection_by_series_id(series_id, 
                                           characters = nil, 
                                           collaborators = nil, 
                                           creators = nil, 
                                           date_descriptor = nil, 
                                           date_range = nil, 
                                           diamond_code = nil, 
                                           digital_id = nil, 
                                           ean = nil, 
                                           events = nil, 
                                           format = 'comic', 
                                           format_type = nil, 
                                           has_digital_issue = 'true', 
                                           isbn = nil, 
                                           issn = nil, 
                                           issue_number = nil, 
                                           limit = nil, 
                                           modified_since = nil, 
                                           no_variants = 'true', 
                                           offset = nil, 
                                           order_by = 'focDate', 
                                           shared_appearances = nil, 
                                           start_year = nil, 
                                           stories = nil, 
                                           title = nil, 
                                           title_starts_with = nil, 
                                           upc = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| series_id |  ``` Required ```  | The series ID. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| date_descriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| date_range |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamond_code |  ``` Optional ```  | Filter by diamond code. |
| digital_id |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| format_type |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| has_digital_issue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issue_number |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| no_variants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| shared_appearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| start_year |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| stories |  ``` Optional ```  | Return only comics which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| title_starts_with |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```ruby
series_id = 'seriesId'
characters = 'characters'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = MarvelComics::DateDescriptorEnum::LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = MarvelComics::FormatTypeEnum::COLLECTION
has_digital_issue = 'true'
isbn = 'isbn'
issn = 'issn'
issue_number = 'issueNumber'
limit = 'limit'
modified_since = 'modifiedSince'
no_variants = 'true'
offset = 'offset'
order_by = 'focDate'
shared_appearances = 'sharedAppearances'
start_year = 'startYear'
stories = 'stories'
title = 'title'
title_starts_with = 'titleStartsWith'
upc = 'upc'

result = comics.get_comics_collection_by_series_id(series_id, characters, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comics_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection_by_story_id") get_comics_collection_by_story_id

> Fetches lists of comics filtered by a story id.


```ruby
def get_comics_collection_by_story_id(story_id, 
                                          characters = nil, 
                                          collaborators = nil, 
                                          creators = nil, 
                                          date_descriptor = nil, 
                                          date_range = nil, 
                                          diamond_code = nil, 
                                          digital_id = nil, 
                                          ean = nil, 
                                          events = nil, 
                                          format = 'comic', 
                                          format_type = nil, 
                                          has_digital_issue = 'true', 
                                          isbn = nil, 
                                          issn = nil, 
                                          issue_number = nil, 
                                          limit = nil, 
                                          modified_since = nil, 
                                          no_variants = 'true', 
                                          offset = nil, 
                                          order_by = 'focDate', 
                                          series = nil, 
                                          shared_appearances = nil, 
                                          start_year = nil, 
                                          title = nil, 
                                          title_starts_with = nil, 
                                          upc = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| story_id |  ``` Required ```  | The story ID. |
| characters |  ``` Optional ```  | Return only comics which feature the specified characters (accepts a comma-separated list of ids). |
| collaborators |  ``` Optional ```  | Return only comics in which the specified creators worked together (for example in which BOTH Stan Lee and Jack Kirby did work). |
| creators |  ``` Optional ```  | Return only comics which feature work by the specified creators (accepts a comma-separated list of ids). |
| date_descriptor |  ``` Optional ```  | Return comics within a predefined date range. |
| date_range |  ``` Optional ```  | Return comics within a predefined date range.  Dates must be specified as date1,date2 (e.g. 2013-01-01,2013-01-02).  Dates are preferably formatted as YYYY-MM-DD but may be sent as any common date format. |
| diamond_code |  ``` Optional ```  | Filter by diamond code. |
| digital_id |  ``` Optional ```  | Filter by digital comic id. |
| ean |  ``` Optional ```  | Filter by EAN. |
| events |  ``` Optional ```  | Return only comics which take place in the specified events (accepts a comma-separated list of ids). |
| format |  ``` Optional ```  ``` DefaultValue ```  | Filter by the issue format (e.g. comic, digital comic, hardcover). (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| format_type |  ``` Optional ```  | Filter by the issue format type (comic or collection). |
| has_digital_issue |  ``` Optional ```  ``` DefaultValue ```  | Include only results which are available digitally. (Acceptable values are: "true") |
| isbn |  ``` Optional ```  | Filter by ISBN. |
| issn |  ``` Optional ```  | Filter by ISSN. |
| issue_number |  ``` Optional ```  | Return only issues in series whose issue number matches the input. |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only comics which have been modified since the specified date. |
| no_variants |  ``` Optional ```  ``` DefaultValue ```  | Exclude variant comics from the result set. (Acceptable values are: "true") |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "focDate", "onsaleDate", "title", "issueNumber", "modified", "-focDate", "-onsaleDate", "-title", "-issueNumber", "-modified") |
| series |  ``` Optional ```  | Return only comics which are part of the specified series (accepts a comma-separated list of ids). |
| shared_appearances |  ``` Optional ```  | Return only comics in which the specified characters appear together (for example in which BOTH Spider-Man and Wolverine appear). |
| start_year |  ``` Optional ```  | Return only issues in series whose start year matches the input. |
| title |  ``` Optional ```  | Return only issues in series whose title matches the input. |
| title_starts_with |  ``` Optional ```  | Return only issues in series whose title starts with the input. |
| upc |  ``` Optional ```  | Filter by UPC. |


#### Example Usage

```ruby
story_id = 'storyId'
characters = 'characters'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = MarvelComics::DateDescriptorEnum::LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = MarvelComics::FormatTypeEnum::COLLECTION
has_digital_issue = 'true'
isbn = 'isbn'
issn = 'issn'
issue_number = 'issueNumber'
limit = 'limit'
modified_since = 'modifiedSince'
no_variants = 'true'
offset = 'offset'
order_by = 'focDate'
series = 'series'
shared_appearances = 'sharedAppearances'
start_year = 'startYear'
title = 'title'
title_starts_with = 'titleStartsWith'
upc = 'upc'

result = comics.get_comics_collection_by_story_id(story_id, characters, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="events_controller"></a>![Class: ](https://apidocs.io/img/class.png ".EventsController") EventsController

### Get singleton instance

The singleton instance of the ``` EventsController ``` class can be accessed from the API Client.

```ruby
events = client.events
```

### <a name="get_character_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_character_events_collection") get_character_events_collection

> Fetches lists of events filtered by a character id.


```ruby
def get_character_events_collection(character_id, 
                                        comics = nil, 
                                        creators = nil, 
                                        limit = nil, 
                                        modified_since = nil, 
                                        name = nil, 
                                        name_starts_with = nil, 
                                        offset = nil, 
                                        order_by = 'name', 
                                        series = nil, 
                                        stories = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| character_id |  ``` Required ```  | The character ID. |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| name_starts_with |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
character_id = 'characterId'
comics = 'comics'
creators = 'creators'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
series = 'series'
stories = 'stories'

result = events.get_character_events_collection(character_id, comics, creators, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_issue_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_issue_events_collection") get_issue_events_collection

> Fetches lists of events filtered by a comic id.


```ruby
def get_issue_events_collection(comic_id, 
                                    characters = nil, 
                                    creators = nil, 
                                    limit = nil, 
                                    modified_since = nil, 
                                    name = nil, 
                                    name_starts_with = nil, 
                                    offset = nil, 
                                    order_by = 'name', 
                                    series = nil, 
                                    stories = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comic_id |  ``` Required ```  | The comic ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| name_starts_with |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
comic_id = 'comicId'
characters = 'characters'
creators = 'creators'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
series = 'series'
stories = 'stories'

result = events.get_issue_events_collection(comic_id, characters, creators, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_creator_events_collection") get_creator_events_collection

> Fetches lists of events filtered by a creator id.


```ruby
def get_creator_events_collection(creator_id, 
                                      characters = nil, 
                                      comics = nil, 
                                      limit = nil, 
                                      modified_since = nil, 
                                      name = nil, 
                                      name_starts_with = nil, 
                                      offset = nil, 
                                      order_by = 'name', 
                                      series = nil, 
                                      stories = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creator_id |  ``` Required ```  | The creator ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| name_starts_with |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
creator_id = 'creatorId'
characters = 'characters'
comics = 'comics'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
series = 'series'
stories = 'stories'

result = events.get_creator_events_collection(creator_id, characters, comics, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_individual"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_event_individual") get_event_individual

> Fetches a single event by id.


```ruby
def get_event_individual(event_id); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| event_id |  ``` Required ```  | A single event. |


#### Example Usage

```ruby
event_id = 'eventId'

result = events.get_event_individual(event_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Event not found. |



### <a name="get_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_events_collection") get_events_collection

> Fetches lists of events.


```ruby
def get_events_collection(characters = nil, 
                              comics = nil, 
                              creators = nil, 
                              limit = nil, 
                              modified_since = nil, 
                              name = nil, 
                              name_starts_with = nil, 
                              offset = nil, 
                              order_by = 'name', 
                              series = nil, 
                              stories = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Return only events which match the specified name. |
| name_starts_with |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only events which take place in the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
characters = 'characters'
comics = 'comics'
creators = 'creators'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
series = 'series'
stories = 'stories'

result = events.get_events_collection(characters, comics, creators, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_events_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_events_collection_by_series_id") get_events_collection_by_series_id

> Fetches lists of events filtered by a series id.


```ruby
def get_events_collection_by_series_id(series_id, 
                                           characters = nil, 
                                           comics = nil, 
                                           creators = nil, 
                                           limit = nil, 
                                           modified_since = nil, 
                                           name = nil, 
                                           name_starts_with = nil, 
                                           offset = nil, 
                                           order_by = 'name', 
                                           stories = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| series_id |  ``` Required ```  | The series ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| name_starts_with |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| stories |  ``` Optional ```  | Return only events which contain the specified stories (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
series_id = 'seriesId'
characters = 'characters'
comics = 'comics'
creators = 'creators'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
stories = 'stories'

result = events.get_events_collection_by_series_id(series_id, characters, comics, creators, limit, modified_since, name, name_starts_with, offset, order_by, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_events_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_events_collection_by_story_id") get_events_collection_by_story_id

> Fetches lists of events filtered by a story id.


```ruby
def get_events_collection_by_story_id(story_id, 
                                          characters = nil, 
                                          comics = nil, 
                                          creators = nil, 
                                          limit = nil, 
                                          modified_since = nil, 
                                          name = nil, 
                                          name_starts_with = nil, 
                                          offset = nil, 
                                          order_by = 'name', 
                                          series = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| story_id |  ``` Required ```  | The story ID. |
| characters |  ``` Optional ```  | Return only events which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only events which take place in the specified comics (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only events which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only events which have been modified since the specified date. |
| name |  ``` Optional ```  | Filter the event list by name. |
| name_starts_with |  ``` Optional ```  | Return events with names that begin with the specified string (e.g. Sp). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "name", "startDate", "modified", "-name", "-startDate", "-modified") |
| series |  ``` Optional ```  | Return only events which are part of the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
story_id = 'storyId'
characters = 'characters'
comics = 'comics'
creators = 'creators'
limit = 'limit'
modified_since = 'modifiedSince'
name = 'name'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'name'
series = 'series'

result = events.get_events_collection_by_story_id(story_id, characters, comics, creators, limit, modified_since, name, name_starts_with, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="series_controller"></a>![Class: ](https://apidocs.io/img/class.png ".SeriesController") SeriesController

### Get singleton instance

The singleton instance of the ``` SeriesController ``` class can be accessed from the API Client.

```ruby
series = client.series
```

### <a name="get_character_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_character_series_collection") get_character_series_collection

> Fetches lists of series filtered by a character id.


```ruby
def get_character_series_collection(character_id, 
                                        comics = nil, 
                                        contains = 'comic', 
                                        creators = nil, 
                                        events = nil, 
                                        limit = nil, 
                                        modified_since = nil, 
                                        offset = nil, 
                                        order_by = 'title', 
                                        series_type = 'collection', 
                                        start_year = nil, 
                                        stories = nil, 
                                        title = nil, 
                                        title_starts_with = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| character_id |  ``` Required ```  | The character ID |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| series_type |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| start_year |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Filter by series title. |
| title_starts_with |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```ruby
character_id = 'characterId'
comics = 'comics'
contains = 'comic'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'title'
series_type = 'collection'
start_year = 'startYear'
stories = 'stories'
title = 'title'
title_starts_with = 'titleStartsWith'

result = series.get_character_series_collection(character_id, comics, contains, creators, events, limit, modified_since, offset, order_by, series_type, start_year, stories, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_individual"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_series_individual") get_series_individual

> Fetches a single comic series by id.


```ruby
def get_series_individual(series_id); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| series_id |  ``` Required ```  | Filter by series title. |


#### Example Usage

```ruby
series_id = 'seriesId'

result = series.get_series_individual(series_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Series not found. |



### <a name="get_creator_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_creator_series_collection") get_creator_series_collection

> Fetches lists of series filtered by a creator id.


```ruby
def get_creator_series_collection(creator_id, 
                                      characters = nil, 
                                      comics = nil, 
                                      contains = 'comic', 
                                      events = nil, 
                                      limit = nil, 
                                      modified_since = nil, 
                                      offset = nil, 
                                      order_by = 'title', 
                                      series_type = 'collection', 
                                      start_year = nil, 
                                      stories = nil, 
                                      title = nil, 
                                      title_starts_with = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creator_id |  ``` Required ```  | The creator ID. |
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| series_type |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| start_year |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Filter by series title. |
| title_starts_with |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```ruby
creator_id = 'creatorId'
characters = 'characters'
comics = 'comics'
contains = 'comic'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'title'
series_type = 'collection'
start_year = 'startYear'
stories = 'stories'
title = 'title'
title_starts_with = 'titleStartsWith'

result = series.get_creator_series_collection(creator_id, characters, comics, contains, events, limit, modified_since, offset, order_by, series_type, start_year, stories, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_event_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_event_series_collection") get_event_series_collection

> Fetches lists of series filtered by an event id.


```ruby
def get_event_series_collection(event_id, 
                                    characters = nil, 
                                    comics = nil, 
                                    contains = 'comic', 
                                    creators = nil, 
                                    limit = nil, 
                                    modified_since = nil, 
                                    offset = nil, 
                                    order_by = 'title', 
                                    series_type = 'collection', 
                                    start_year = nil, 
                                    stories = nil, 
                                    title = nil, 
                                    title_starts_with = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| event_id |  ``` Required ```  | The event ID. |
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| series_type |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| start_year |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Filter by series title. |
| title_starts_with |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```ruby
event_id = 'eventId'
characters = 'characters'
comics = 'comics'
contains = 'comic'
creators = 'creators'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'title'
series_type = 'collection'
start_year = 'startYear'
stories = 'stories'
title = 'title'
title_starts_with = 'titleStartsWith'

result = series.get_event_series_collection(event_id, characters, comics, contains, creators, limit, modified_since, offset, order_by, series_type, start_year, stories, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_series_collection") get_series_collection

> Fetches lists of series.


```ruby
def get_series_collection(characters = nil, 
                              comics = nil, 
                              contains = 'comic', 
                              creators = nil, 
                              events = nil, 
                              limit = nil, 
                              modified_since = nil, 
                              offset = nil, 
                              order_by = 'title', 
                              series_type = 'collection', 
                              start_year = nil, 
                              stories = nil, 
                              title = nil, 
                              title_starts_with = nil); end
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
| modified_since |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| series_type |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| start_year |  ``` Optional ```  | Return only series matching the specified start year. |
| stories |  ``` Optional ```  | Return only series which contain the specified stories (accepts a comma-separated list of ids). |
| title |  ``` Optional ```  | Return only series matching the specified title. |
| title_starts_with |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```ruby
characters = 'characters'
comics = 'comics'
contains = 'comic'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'title'
series_type = 'collection'
start_year = 'startYear'
stories = 'stories'
title = 'title'
title_starts_with = 'titleStartsWith'

result = series.get_series_collection(characters, comics, contains, creators, events, limit, modified_since, offset, order_by, series_type, start_year, stories, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_story_series_collection") get_story_series_collection

> Fetches lists of series filtered by a story id.


```ruby
def get_story_series_collection(story_id, 
                                    characters = nil, 
                                    comics = nil, 
                                    contains = 'comic', 
                                    creators = nil, 
                                    events = nil, 
                                    limit = nil, 
                                    modified_since = nil, 
                                    offset = nil, 
                                    order_by = 'title', 
                                    series_type = 'collection', 
                                    start_year = nil, 
                                    title = nil, 
                                    title_starts_with = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| story_id |  ``` Required ```  | The story ID. |
| characters |  ``` Optional ```  | Return only series which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only series which contain the specified comics (accepts a comma-separated list of ids). |
| contains |  ``` Optional ```  ``` DefaultValue ```  | Return only series containing one or more comics with the specified format. (Acceptable values are: "comic", "magazine", "trade paperback", "hardcover", "digest", "graphic novel", "digital comic", "infinite comic") |
| creators |  ``` Optional ```  | Return only series which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only series which have comics that take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only series which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "title", "modified", "startYear", "-title", "-modified", "-startYear") |
| series_type |  ``` Optional ```  ``` DefaultValue ```  | Filter the series by publication frequency type. (Acceptable values are: "collection", "one shot", "limited", "ongoing") |
| start_year |  ``` Optional ```  | Return only series matching the specified start year. |
| title |  ``` Optional ```  | Filter by series title. |
| title_starts_with |  ``` Optional ```  | Return series with titles that begin with the specified string (e.g. Sp). |


#### Example Usage

```ruby
story_id = 'storyId'
characters = 'characters'
comics = 'comics'
contains = 'comic'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'title'
series_type = 'collection'
start_year = 'startYear'
title = 'title'
title_starts_with = 'titleStartsWith'

result = series.get_story_series_collection(story_id, characters, comics, contains, creators, events, limit, modified_since, offset, order_by, series_type, start_year, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="stories_controller"></a>![Class: ](https://apidocs.io/img/class.png ".StoriesController") StoriesController

### Get singleton instance

The singleton instance of the ``` StoriesController ``` class can be accessed from the API Client.

```ruby
stories = client.stories
```

### <a name="get_character_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_character_story_collection") get_character_story_collection

> Fetches lists of stories filtered by a character id.


```ruby
def get_character_story_collection(character_id, 
                                       comics = nil, 
                                       creators = nil, 
                                       events = nil, 
                                       limit = nil, 
                                       modified_since = nil, 
                                       offset = nil, 
                                       order_by = 'id', 
                                       series = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| character_id |  ``` Required ```  | The character ID. |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
character_id = 'characterId'
comics = 'comics'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories.get_character_story_collection(character_id, comics, creators, events, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_comic_story_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_comic_story_collection_by_comic_id") get_comic_story_collection_by_comic_id

> Fetches lists of stories filtered by a comic id.


```ruby
def get_comic_story_collection_by_comic_id(comic_id, 
                                               characters = nil, 
                                               creators = nil, 
                                               events = nil, 
                                               limit = nil, 
                                               modified_since = nil, 
                                               offset = nil, 
                                               order_by = 'id', 
                                               series = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comic_id |  ``` Required ```  | The comic ID. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
comic_id = 'comicId'
characters = 'characters'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories.get_comic_story_collection_by_comic_id(comic_id, characters, creators, events, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_creator_story_collection") get_creator_story_collection

> Fetches lists of stories filtered by a creator id.


```ruby
def get_creator_story_collection(creator_id, 
                                     characters = nil, 
                                     comics = nil, 
                                     events = nil, 
                                     limit = nil, 
                                     modified_since = nil, 
                                     offset = nil, 
                                     order_by = 'id', 
                                     series = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creator_id |  ``` Required ```  | The ID of the creator. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
creator_id = 'creatorId'
characters = 'characters'
comics = 'comics'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories.get_creator_story_collection(creator_id, characters, comics, events, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_individual"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_story_individual") get_story_individual

> Fetches a single comic story by id.


```ruby
def get_story_individual(story_id); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| story_id |  ``` Required ```  | Filter by story id. |


#### Example Usage

```ruby
story_id = 'storyId'

result = stories.get_story_individual(story_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Story not found. |



### <a name="get_event_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_event_story_collection") get_event_story_collection

> Fetches lists of stories filtered by an event id.


```ruby
def get_event_story_collection(event_id, 
                                   characters = nil, 
                                   comics = nil, 
                                   creators = nil, 
                                   limit = nil, 
                                   modified_since = nil, 
                                   offset = nil, 
                                   order_by = 'id', 
                                   series = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| event_id |  ``` Required ```  | The ID of the event. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
event_id = 'eventId'
characters = 'characters'
comics = 'comics'
creators = 'creators'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories.get_event_story_collection(event_id, characters, comics, creators, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_series_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_series_story_collection") get_series_story_collection

> Fetches lists of stories filtered by a series id.


```ruby
def get_series_story_collection(series_id, 
                                    characters = nil, 
                                    comics = nil, 
                                    creators = nil, 
                                    events = nil, 
                                    limit = nil, 
                                    modified_since = nil, 
                                    offset = nil, 
                                    order_by = 'id'); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| series_id |  ``` Required ```  | The series ID. |
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |


#### Example Usage

```ruby
series_id = 'seriesId'
characters = 'characters'
comics = 'comics'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'

result = stories.get_series_story_collection(series_id, characters, comics, creators, events, limit, modified_since, offset, order_by)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_story_collection") get_story_collection

> Fetches lists of stories.


```ruby
def get_story_collection(characters = nil, 
                             comics = nil, 
                             creators = nil, 
                             events = nil, 
                             limit = nil, 
                             modified_since = nil, 
                             offset = nil, 
                             order_by = 'id', 
                             series = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characters |  ``` Optional ```  | Return only stories which feature the specified characters (accepts a comma-separated list of ids). |
| comics |  ``` Optional ```  | Return only stories contained in the specified (accepts a comma-separated list of ids). |
| creators |  ``` Optional ```  | Return only stories which feature work by the specified creators (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only stories which take place during the specified events (accepts a comma-separated list of ids). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| modified_since |  ``` Optional ```  | Return only stories which have been modified since the specified date. |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "id", "modified", "-id", "-modified") |
| series |  ``` Optional ```  | Return only stories contained the specified series (accepts a comma-separated list of ids). |


#### Example Usage

```ruby
characters = 'characters'
comics = 'comics'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories.get_story_collection(characters, comics, creators, events, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)

## <a name="creators_controller"></a>![Class: ](https://apidocs.io/img/class.png ".CreatorsController") CreatorsController

### Get singleton instance

The singleton instance of the ``` CreatorsController ``` class can be accessed from the API Client.

```ruby
creators = client.creators
```

### <a name="get_creator_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection_by_comic_id") get_creator_collection_by_comic_id

> Fetches lists of creators filtered by a comic id.


```ruby
def get_creator_collection_by_comic_id(comic_id, 
                                           comics = nil, 
                                           first_name = nil, 
                                           first_name_starts_with = nil, 
                                           last_name = nil, 
                                           last_name_starts_with = nil, 
                                           limit = nil, 
                                           middle_name = nil, 
                                           middle_name_starts_with = nil, 
                                           modified_since = nil, 
                                           name_starts_with = nil, 
                                           offset = nil, 
                                           order_by = 'lastName', 
                                           series = nil, 
                                           stories = nil, 
                                           suffix = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comic_id |  ``` Required ```  | The comic id. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| first_name |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| first_name_starts_with |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| last_name |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| last_name_starts_with |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middle_name |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middle_name_starts_with |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modified_since |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| name_starts_with |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```ruby
comic_id = 'comicId'
comics = 'comics'
first_name = 'firstName'
first_name_starts_with = 'firstNameStartsWith'
last_name = 'lastName'
last_name_starts_with = 'lastNameStartsWith'
limit = 'limit'
middle_name = 'middleName'
middle_name_starts_with = 'middleNameStartsWith'
modified_since = 'modifiedSince'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'lastName'
series = 'series'
stories = 'stories'
suffix = 'suffix'

result = creators.get_creator_collection_by_comic_id(comic_id, comics, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, series, stories, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection") get_creator_collection

> Fetches lists of creators.


```ruby
def get_creator_collection(comics = nil, 
                               events = nil, 
                               first_name = nil, 
                               first_name_starts_with = nil, 
                               last_name = nil, 
                               last_name_starts_with = nil, 
                               limit = nil, 
                               middle_name = nil, 
                               middle_name_starts_with = nil, 
                               modified_since = nil, 
                               name_starts_with = nil, 
                               offset = nil, 
                               order_by = 'lastName', 
                               series = nil, 
                               stories = nil, 
                               suffix = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). |
| first_name |  ``` Optional ```  | Filter by creator first name (e.g. Brian). |
| first_name_starts_with |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| last_name |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| last_name_starts_with |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middle_name |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middle_name_starts_with |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modified_since |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| name_starts_with |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```ruby
comics = 'comics'
events = 'events'
first_name = 'firstName'
first_name_starts_with = 'firstNameStartsWith'
last_name = 'lastName'
last_name_starts_with = 'lastNameStartsWith'
limit = 'limit'
middle_name = 'middleName'
middle_name_starts_with = 'middleNameStartsWith'
modified_since = 'modifiedSince'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'lastName'
series = 'series'
stories = 'stories'
suffix = 'suffix'

result = creators.get_creator_collection(comics, events, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, series, stories, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_individual") get_creator_individual

> Fetches a single creator by id.


```ruby
def get_creator_individual(creator_id); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creator_id |  ``` Required ```  | A single creator id. |


#### Example Usage

```ruby
creator_id = 'creatorId'

result = creators.get_creator_individual(creator_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Creator not found. |



### <a name="get_creator_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection_by_event_id") get_creator_collection_by_event_id

> Fetches lists of creators filtered by an event id.


```ruby
def get_creator_collection_by_event_id(event_id, 
                                           comics = nil, 
                                           first_name = nil, 
                                           first_name_starts_with = nil, 
                                           last_name = nil, 
                                           last_name_starts_with = nil, 
                                           limit = nil, 
                                           middle_name = nil, 
                                           middle_name_starts_with = nil, 
                                           modified_since = nil, 
                                           name_starts_with = nil, 
                                           offset = nil, 
                                           order_by = 'lastName', 
                                           series = nil, 
                                           stories = nil, 
                                           suffix = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| event_id |  ``` Required ```  | The event ID. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| first_name |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| first_name_starts_with |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| last_name |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| last_name_starts_with |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middle_name |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middle_name_starts_with |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modified_since |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| name_starts_with |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```ruby
event_id = 'eventId'
comics = 'comics'
first_name = 'firstName'
first_name_starts_with = 'firstNameStartsWith'
last_name = 'lastName'
last_name_starts_with = 'lastNameStartsWith'
limit = 'limit'
middle_name = 'middleName'
middle_name_starts_with = 'middleNameStartsWith'
modified_since = 'modifiedSince'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'lastName'
series = 'series'
stories = 'stories'
suffix = 'suffix'

result = creators.get_creator_collection_by_event_id(event_id, comics, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, series, stories, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection_by_series_id") get_creator_collection_by_series_id

> Fetches lists of creators filtered by a series id.


```ruby
def get_creator_collection_by_series_id(series_id, 
                                            comics = nil, 
                                            events = nil, 
                                            first_name = nil, 
                                            first_name_starts_with = nil, 
                                            last_name = nil, 
                                            last_name_starts_with = nil, 
                                            limit = nil, 
                                            middle_name = nil, 
                                            middle_name_starts_with = nil, 
                                            modified_since = nil, 
                                            name_starts_with = nil, 
                                            offset = nil, 
                                            order_by = 'lastName', 
                                            stories = nil, 
                                            suffix = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| series_id |  ``` Required ```  | The series ID. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). |
| first_name |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| first_name_starts_with |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| last_name |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| last_name_starts_with |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middle_name |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middle_name_starts_with |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modified_since |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| name_starts_with |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| stories |  ``` Optional ```  | Return only creators who worked on the specified stories (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```ruby
series_id = 'seriesId'
comics = 'comics'
events = 'events'
first_name = 'firstName'
first_name_starts_with = 'firstNameStartsWith'
last_name = 'lastName'
last_name_starts_with = 'lastNameStartsWith'
limit = 'limit'
middle_name = 'middleName'
middle_name_starts_with = 'middleNameStartsWith'
modified_since = 'modifiedSince'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'lastName'
stories = 'stories'
suffix = 'suffix'

result = creators.get_creator_collection_by_series_id(series_id, comics, events, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, stories, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



### <a name="get_creator_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection_by_story_id") get_creator_collection_by_story_id

> Fetches lists of creators filtered by a story id.


```ruby
def get_creator_collection_by_story_id(story_id, 
                                           comics = nil, 
                                           events = nil, 
                                           first_name = nil, 
                                           first_name_starts_with = nil, 
                                           last_name = nil, 
                                           last_name_starts_with = nil, 
                                           limit = nil, 
                                           middle_name = nil, 
                                           middle_name_starts_with = nil, 
                                           modified_since = nil, 
                                           name_starts_with = nil, 
                                           offset = nil, 
                                           order_by = 'lastName', 
                                           series = nil, 
                                           suffix = nil); end
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| story_id |  ``` Required ```  | The story ID. |
| comics |  ``` Optional ```  | Return only creators who worked on in the specified comics (accepts a comma-separated list of ids). |
| events |  ``` Optional ```  | Return only creators who worked on comics that took place in the specified events (accepts a comma-separated list of ids). |
| first_name |  ``` Optional ```  | Filter by creator first name (e.g. brian). |
| first_name_starts_with |  ``` Optional ```  | Filter by creator first names that match critera (e.g. B, St L). |
| last_name |  ``` Optional ```  | Filter by creator last name (e.g. Bendis). |
| last_name_starts_with |  ``` Optional ```  | Filter by creator last names that match critera (e.g. Ben). |
| limit |  ``` Optional ```  | Limit the result set to the specified number of resources. |
| middle_name |  ``` Optional ```  | Filter by creator middle name (e.g. Michael). |
| middle_name_starts_with |  ``` Optional ```  | Filter by creator middle names that match critera (e.g. Mi). |
| modified_since |  ``` Optional ```  | Return only creators which have been modified since the specified date. |
| name_starts_with |  ``` Optional ```  | Filter by creator names that match critera (e.g. B, St L). |
| offset |  ``` Optional ```  | Skip the specified number of resources in the result set. |
| order_by |  ``` Optional ```  ``` DefaultValue ```  | Order the result set by a field or fields. Add a "-" to the value sort in descending order. Multiple values are given priority in the order in which they are passed. (Acceptable values are: "lastName", "firstName", "middleName", "suffix", "modified", "-lastName", "-firstName", "-middleName", "-suffix", "-modified") |
| series |  ``` Optional ```  | Return only creators who worked on the specified series (accepts a comma-separated list of ids). |
| suffix |  ``` Optional ```  | Filter by suffix or honorific (e.g. Jr., Sr.). |


#### Example Usage

```ruby
story_id = 'storyId'
comics = 'comics'
events = 'events'
first_name = 'firstName'
first_name_starts_with = 'firstNameStartsWith'
last_name = 'lastName'
last_name_starts_with = 'lastNameStartsWith'
limit = 'limit'
middle_name = 'middleName'
middle_name_starts_with = 'middleNameStartsWith'
modified_since = 'modifiedSince'
name_starts_with = 'nameStartsWith'
offset = 'offset'
order_by = 'lastName'
series = 'series'
suffix = 'suffix'

result = creators.get_creator_collection_by_story_id(story_id, comics, events, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, series, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |



[Back to List of Controllers](#list_of_controllers)



