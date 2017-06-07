# Getting started

## How to Build


You must have Python 2 >=2.7.9 or Python 3 >=3.4 installed on your system to install and run this SDK. This SDK package depends on other Python packages like nose, jsonpickle etc. 
These dependencies are defined in the ```requirements.txt``` file that comes with the SDK.
To resolve these dependencies, you can use the PIP Dependency manager. Install it by following steps at [https://pip.pypa.io/en/stable/installing/](https://pip.pypa.io/en/stable/installing/).

Python and PIP executables should be defined in your PATH. Open command prompt and type ```pip --version```.
This should display the version of the PIP Dependency Manager installed if your installation was successful and the paths are properly defined.

* Using command line, navigate to the directory containing the generated files (including ```requirements.txt```) for the SDK.
* Run the command ```pip install -r requirements.txt```. This should install all the required dependencies.

![Building SDK - Step 1](https://apidocs.io/illustration/python?step=installDependencies&workspaceFolder=MarvelComics-Python)


## How to Use

The following section explains how to use the Marvelcomics SDK package in a new project.

### 1. Open Project in an IDE

Open up a Python IDE like PyCharm. The basic workflow presented here is also applicable if you prefer using a different editor or IDE.

![Open project in PyCharm - Step 1](https://apidocs.io/illustration/python?step=pyCharm)

Click on ```Open``` in PyCharm to browse to your generated SDK directory and then click ```OK```.

![Open project in PyCharm - Step 2](https://apidocs.io/illustration/python?step=openProject0&workspaceFolder=MarvelComics-Python)     

The project files will be displayed in the side bar as follows:

![Open project in PyCharm - Step 3](https://apidocs.io/illustration/python?step=openProject1&workspaceFolder=MarvelComics-Python&projectName=marvelcomics)     

### 2. Add a new Test Project

Create a new directory by right clicking on the solution name as shown below:

![Add a new project in PyCharm - Step 1](https://apidocs.io/illustration/python?step=createDirectory&workspaceFolder=MarvelComics-Python&projectName=marvelcomics)

Name the directory as "test"

![Add a new project in PyCharm - Step 2](https://apidocs.io/illustration/python?step=nameDirectory)
   
Add a python file to this project with the name "testsdk"

![Add a new project in PyCharm - Step 3](https://apidocs.io/illustration/python?step=createFile&workspaceFolder=MarvelComics-Python&projectName=marvelcomics)

Name it "testsdk"

![Add a new project in PyCharm - Step 4](https://apidocs.io/illustration/python?step=nameFile)

In your python file you will be required to import the generated python library using the following code lines

```Python
from marvelcomics.marvelcomics_client.py import *
```

![Add a new project in PyCharm - Step 4](https://apidocs.io/illustration/python?step=projectFiles&workspaceFolder=MarvelComics-Python&libraryName=marvelcomics.marvelcomics_client.py&projectName=marvelcomics)

After this you can write code to instantiate an API client object, get a controller object and  make API calls. Sample code is given in the subsequent sections.

### 3. Run the Test Project

To run the file within your test project, right click on your Python file inside your Test project and click on ```Run```

![Run Test Project - Step 1](https://apidocs.io/illustration/python?step=runProject&workspaceFolder=MarvelComics-Python&libraryName=marvelcomics.marvelcomics_client.py&projectName=marvelcomics)


## How to Test

You can test the generated SDK and the server with automatically generated test
cases. unittest is used as the testing framework and nose is used as the test
runner. You can run the tests as follows:

  1. From terminal/cmd navigate to the root directory of the SDK.
  2. Invoke 'pip install -r test-requirements.txt'
  3. Invoke 'nosetests'

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| referer | TODO: add a description |
| apikey | TODO: add a description |



API client can be initialized as following.

```python
# Configuration parameters and credentials
referer = "*.marvel.com"
apikey = "apikey"

client = MarvelcomicsClient(referer, apikey)
```

# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [CharactersController](#characters_controller)
* [ComicsController](#comics_controller)
* [EventsController](#events_controller)
* [SeriesController](#series_controller)
* [StoriesController](#stories_controller)
* [CreatorsController](#creators_controller)

## <a name="characters_controller"></a>![Class: ](https://apidocs.io/img/class.png ".CharactersController") CharactersController

### Get controller instance

An instance of the ``` CharactersController ``` class can be accessed from the API Client.

```python
 characters_client = client.characters
```

### <a name="get_character_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_character_individual") get_character_individual

> Fetches a single character by id.

```python
def get_character_individual(self,
                                 character_id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| characterId |  ``` Required ```  | A single character id. |



#### Example Usage

```python
character_id = 'characterId'

result = characters_client.get_character_individual(character_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Character not found. |




### <a name="get_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_character_collection") get_character_collection

> Fetches lists of characters.

```python
def get_character_collection(self,
                                 comics=None,
                                 events=None,
                                 limit=None,
                                 modified_since=None,
                                 name=None,
                                 name_starts_with=None,
                                 offset=None,
                                 order_by='name',
                                 series=None,
                                 stories=None)
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

```python
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

result = characters_client.get_character_collection(comics, events, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comic_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_comic_character_collection") get_comic_character_collection

> Fetches lists of characters filtered by a comic id.

```python
def get_comic_character_collection(self,
                                       comic_id,
                                       events=None,
                                       limit=None,
                                       modified_since=None,
                                       name=None,
                                       name_starts_with=None,
                                       offset=None,
                                       order_by='name',
                                       series=None,
                                       stories=None)
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

```python
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

result = characters_client.get_comic_character_collection(comic_id, events, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_event_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_event_character_collection") get_event_character_collection

> Fetches lists of characters filtered by an event id.

```python
def get_event_character_collection(self,
                                       event_id,
                                       comics=None,
                                       limit=None,
                                       modified_since=None,
                                       name=None,
                                       name_starts_with=None,
                                       offset=None,
                                       order_by='name',
                                       series=None,
                                       stories=None)
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

```python
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

result = characters_client.get_event_character_collection(event_id, comics, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_character_wrapper"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_series_character_wrapper") get_series_character_wrapper

> Fetches lists of characters filtered by a series id.

```python
def get_series_character_wrapper(self,
                                     series_id,
                                     comics=None,
                                     events=None,
                                     limit=None,
                                     modified_since=None,
                                     name=None,
                                     name_starts_with=None,
                                     offset=None,
                                     order_by='name',
                                     stories=None)
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

```python
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

result = characters_client.get_series_character_wrapper(series_id, comics, events, limit, modified_since, name, name_starts_with, offset, order_by, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_character_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CharactersController.get_character_collection_by_story_id") get_character_collection_by_story_id

> Fetches lists of characters filtered by a story id.

```python
def get_character_collection_by_story_id(self,
                                             story_id,
                                             comics=None,
                                             events=None,
                                             limit=None,
                                             modified_since=None,
                                             name=None,
                                             name_starts_with=None,
                                             offset=None,
                                             order_by='name',
                                             series=None)
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

```python
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

result = characters_client.get_character_collection_by_story_id(story_id, comics, events, limit, modified_since, name, name_starts_with, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="comics_controller"></a>![Class: ](https://apidocs.io/img/class.png ".ComicsController") ComicsController

### Get controller instance

An instance of the ``` ComicsController ``` class can be accessed from the API Client.

```python
 comics_client = client.comics
```

### <a name="get_comics_character_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_character_collection") get_comics_character_collection

> Fetches lists of comics filtered by a character id.

```python
def get_comics_character_collection(self,
                                        character_id,
                                        collaborators=None,
                                        creators=None,
                                        date_descriptor=None,
                                        date_range=None,
                                        diamond_code=None,
                                        digital_id=None,
                                        ean=None,
                                        events=None,
                                        format='comic',
                                        format_type=None,
                                        has_digital_issue='true',
                                        isbn=None,
                                        issn=None,
                                        issue_number=None,
                                        limit=None,
                                        modified_since=None,
                                        no_variants='true',
                                        offset=None,
                                        order_by='focDate',
                                        series=None,
                                        shared_appearances=None,
                                        start_year=None,
                                        stories=None,
                                        title=None,
                                        title_starts_with=None,
                                        upc=None)
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

```python
character_id = 'characterId'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = DateDescriptorEnum.LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = FormatTypeEnum.COLLECTION
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

result = comics_client.get_comics_character_collection(character_id, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection") get_comics_collection

> Fetches lists of comics.

```python
def get_comics_collection(self,
                              characters=None,
                              collaborators=None,
                              creators=None,
                              date_descriptor=None,
                              date_range=None,
                              diamond_code=None,
                              digital_id=None,
                              ean=None,
                              events=None,
                              format='comic',
                              format_type=None,
                              has_digital_issue='true',
                              isbn=None,
                              issn=None,
                              issue_number=None,
                              limit=None,
                              modified_since=None,
                              no_variants='true',
                              offset=None,
                              order_by='focDate',
                              series=None,
                              shared_appearances=None,
                              start_year=None,
                              stories=None,
                              title=None,
                              title_starts_with=None,
                              upc=None)
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

```python
characters = 'characters'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = DateDescriptorEnum.LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = FormatTypeEnum.COLLECTION
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

result = comics_client.get_comics_collection(characters, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comic_individual"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comic_individual") get_comic_individual

> Fetches a single comic by id.

```python
def get_comic_individual(self,
                             comic_id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| comicId |  ``` Required ```  | A single comic. |



#### Example Usage

```python
comic_id = 'comicId'

result = comics_client.get_comic_individual(comic_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Comic not found. |




### <a name="get_comics_collection_by_creator_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection_by_creator_id") get_comics_collection_by_creator_id

> Fetches lists of comics filtered by a creator id.

```python
def get_comics_collection_by_creator_id(self,
                                            creator_id,
                                            characters=None,
                                            collaborators=None,
                                            date_descriptor=None,
                                            date_range=None,
                                            diamond_code=None,
                                            digital_id=None,
                                            ean=None,
                                            events=None,
                                            format='comic',
                                            format_type=None,
                                            has_digital_issue='true',
                                            isbn=None,
                                            issn=None,
                                            issue_number=None,
                                            limit=None,
                                            modified_since=None,
                                            no_variants='true',
                                            offset=None,
                                            order_by='focDate',
                                            series=None,
                                            shared_appearances=None,
                                            start_year=None,
                                            stories=None,
                                            title=None,
                                            title_starts_with=None,
                                            upc=None)
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

```python
creator_id = 'creatorId'
characters = 'characters'
collaborators = 'collaborators'
date_descriptor = DateDescriptorEnum.LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = FormatTypeEnum.COLLECTION
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

result = comics_client.get_comics_collection_by_creator_id(creator_id, characters, collaborators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection_by_event_id") get_comics_collection_by_event_id

> Fetches lists of comics filtered by an event id.

```python
def get_comics_collection_by_event_id(self,
                                          event_id,
                                          characters=None,
                                          collaborators=None,
                                          creators=None,
                                          date_descriptor=None,
                                          date_range=None,
                                          diamond_code=None,
                                          digital_id=None,
                                          ean=None,
                                          events=None,
                                          format='comic',
                                          format_type=None,
                                          has_digital_issue='true',
                                          isbn=None,
                                          issn=None,
                                          issue_number=None,
                                          limit=None,
                                          modified_since=None,
                                          no_variants='true',
                                          offset=None,
                                          order_by='focDate',
                                          series=None,
                                          shared_appearances=None,
                                          start_year=None,
                                          stories=None,
                                          title=None,
                                          title_starts_with=None,
                                          upc=None)
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

```python
event_id = 'eventId'
characters = 'characters'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = DateDescriptorEnum.LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = FormatTypeEnum.COLLECTION
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

result = comics_client.get_comics_collection_by_event_id(event_id, characters, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection_by_series_id") get_comics_collection_by_series_id

> Fetches lists of comics filtered by a series id.

```python
def get_comics_collection_by_series_id(self,
                                           series_id,
                                           characters=None,
                                           collaborators=None,
                                           creators=None,
                                           date_descriptor=None,
                                           date_range=None,
                                           diamond_code=None,
                                           digital_id=None,
                                           ean=None,
                                           events=None,
                                           format='comic',
                                           format_type=None,
                                           has_digital_issue='true',
                                           isbn=None,
                                           issn=None,
                                           issue_number=None,
                                           limit=None,
                                           modified_since=None,
                                           no_variants='true',
                                           offset=None,
                                           order_by='focDate',
                                           shared_appearances=None,
                                           start_year=None,
                                           stories=None,
                                           title=None,
                                           title_starts_with=None,
                                           upc=None)
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

```python
series_id = 'seriesId'
characters = 'characters'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = DateDescriptorEnum.LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = FormatTypeEnum.COLLECTION
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

result = comics_client.get_comics_collection_by_series_id(series_id, characters, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, shared_appearances, start_year, stories, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comics_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".ComicsController.get_comics_collection_by_story_id") get_comics_collection_by_story_id

> Fetches lists of comics filtered by a story id.

```python
def get_comics_collection_by_story_id(self,
                                          story_id,
                                          characters=None,
                                          collaborators=None,
                                          creators=None,
                                          date_descriptor=None,
                                          date_range=None,
                                          diamond_code=None,
                                          digital_id=None,
                                          ean=None,
                                          events=None,
                                          format='comic',
                                          format_type=None,
                                          has_digital_issue='true',
                                          isbn=None,
                                          issn=None,
                                          issue_number=None,
                                          limit=None,
                                          modified_since=None,
                                          no_variants='true',
                                          offset=None,
                                          order_by='focDate',
                                          series=None,
                                          shared_appearances=None,
                                          start_year=None,
                                          title=None,
                                          title_starts_with=None,
                                          upc=None)
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

```python
story_id = 'storyId'
characters = 'characters'
collaborators = 'collaborators'
creators = 'creators'
date_descriptor = DateDescriptorEnum.LASTWEEK
date_range = 'dateRange'
diamond_code = 'diamondCode'
digital_id = 'digitalId'
ean = 'ean'
events = 'events'
format = 'comic'
format_type = FormatTypeEnum.COLLECTION
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

result = comics_client.get_comics_collection_by_story_id(story_id, characters, collaborators, creators, date_descriptor, date_range, diamond_code, digital_id, ean, events, format, format_type, has_digital_issue, isbn, issn, issue_number, limit, modified_since, no_variants, offset, order_by, series, shared_appearances, start_year, title, title_starts_with, upc)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="events_controller"></a>![Class: ](https://apidocs.io/img/class.png ".EventsController") EventsController

### Get controller instance

An instance of the ``` EventsController ``` class can be accessed from the API Client.

```python
 events_client = client.events
```

### <a name="get_character_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_character_events_collection") get_character_events_collection

> Fetches lists of events filtered by a character id.

```python
def get_character_events_collection(self,
                                        character_id,
                                        comics=None,
                                        creators=None,
                                        limit=None,
                                        modified_since=None,
                                        name=None,
                                        name_starts_with=None,
                                        offset=None,
                                        order_by='name',
                                        series=None,
                                        stories=None)
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

```python
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

result = events_client.get_character_events_collection(character_id, comics, creators, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_issue_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_issue_events_collection") get_issue_events_collection

> Fetches lists of events filtered by a comic id.

```python
def get_issue_events_collection(self,
                                    comic_id,
                                    characters=None,
                                    creators=None,
                                    limit=None,
                                    modified_since=None,
                                    name=None,
                                    name_starts_with=None,
                                    offset=None,
                                    order_by='name',
                                    series=None,
                                    stories=None)
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

```python
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

result = events_client.get_issue_events_collection(comic_id, characters, creators, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_creator_events_collection") get_creator_events_collection

> Fetches lists of events filtered by a creator id.

```python
def get_creator_events_collection(self,
                                      creator_id,
                                      characters=None,
                                      comics=None,
                                      limit=None,
                                      modified_since=None,
                                      name=None,
                                      name_starts_with=None,
                                      offset=None,
                                      order_by='name',
                                      series=None,
                                      stories=None)
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

```python
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

result = events_client.get_creator_events_collection(creator_id, characters, comics, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_event_individual"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_event_individual") get_event_individual

> Fetches a single event by id.

```python
def get_event_individual(self,
                             event_id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| eventId |  ``` Required ```  | A single event. |



#### Example Usage

```python
event_id = 'eventId'

result = events_client.get_event_individual(event_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Event not found. |




### <a name="get_events_collection"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_events_collection") get_events_collection

> Fetches lists of events.

```python
def get_events_collection(self,
                              characters=None,
                              comics=None,
                              creators=None,
                              limit=None,
                              modified_since=None,
                              name=None,
                              name_starts_with=None,
                              offset=None,
                              order_by='name',
                              series=None,
                              stories=None)
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

```python
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

result = events_client.get_events_collection(characters, comics, creators, limit, modified_since, name, name_starts_with, offset, order_by, series, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_events_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_events_collection_by_series_id") get_events_collection_by_series_id

> Fetches lists of events filtered by a series id.

```python
def get_events_collection_by_series_id(self,
                                           series_id,
                                           characters=None,
                                           comics=None,
                                           creators=None,
                                           limit=None,
                                           modified_since=None,
                                           name=None,
                                           name_starts_with=None,
                                           offset=None,
                                           order_by='name',
                                           stories=None)
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

```python
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

result = events_client.get_events_collection_by_series_id(series_id, characters, comics, creators, limit, modified_since, name, name_starts_with, offset, order_by, stories)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_events_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".EventsController.get_events_collection_by_story_id") get_events_collection_by_story_id

> Fetches lists of events filtered by a story id.

```python
def get_events_collection_by_story_id(self,
                                          story_id,
                                          characters=None,
                                          comics=None,
                                          creators=None,
                                          limit=None,
                                          modified_since=None,
                                          name=None,
                                          name_starts_with=None,
                                          offset=None,
                                          order_by='name',
                                          series=None)
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

```python
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

result = events_client.get_events_collection_by_story_id(story_id, characters, comics, creators, limit, modified_since, name, name_starts_with, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="series_controller"></a>![Class: ](https://apidocs.io/img/class.png ".SeriesController") SeriesController

### Get controller instance

An instance of the ``` SeriesController ``` class can be accessed from the API Client.

```python
 series_client = client.series
```

### <a name="get_character_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_character_series_collection") get_character_series_collection

> Fetches lists of series filtered by a character id.

```python
def get_character_series_collection(self,
                                        character_id,
                                        comics=None,
                                        contains='comic',
                                        creators=None,
                                        events=None,
                                        limit=None,
                                        modified_since=None,
                                        offset=None,
                                        order_by='title',
                                        series_type='collection',
                                        start_year=None,
                                        stories=None,
                                        title=None,
                                        title_starts_with=None)
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

```python
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

result = series_client.get_character_series_collection(character_id, comics, contains, creators, events, limit, modified_since, offset, order_by, series_type, start_year, stories, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_individual"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_series_individual") get_series_individual

> Fetches a single comic series by id.

```python
def get_series_individual(self,
                              series_id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| seriesId |  ``` Required ```  | Filter by series title. |



#### Example Usage

```python
series_id = 'seriesId'

result = series_client.get_series_individual(series_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Series not found. |




### <a name="get_creator_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_creator_series_collection") get_creator_series_collection

> Fetches lists of series filtered by a creator id.

```python
def get_creator_series_collection(self,
                                      creator_id,
                                      characters=None,
                                      comics=None,
                                      contains='comic',
                                      events=None,
                                      limit=None,
                                      modified_since=None,
                                      offset=None,
                                      order_by='title',
                                      series_type='collection',
                                      start_year=None,
                                      stories=None,
                                      title=None,
                                      title_starts_with=None)
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

```python
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

result = series_client.get_creator_series_collection(creator_id, characters, comics, contains, events, limit, modified_since, offset, order_by, series_type, start_year, stories, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_event_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_event_series_collection") get_event_series_collection

> Fetches lists of series filtered by an event id.

```python
def get_event_series_collection(self,
                                    event_id,
                                    characters=None,
                                    comics=None,
                                    contains='comic',
                                    creators=None,
                                    limit=None,
                                    modified_since=None,
                                    offset=None,
                                    order_by='title',
                                    series_type='collection',
                                    start_year=None,
                                    stories=None,
                                    title=None,
                                    title_starts_with=None)
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

```python
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

result = series_client.get_event_series_collection(event_id, characters, comics, contains, creators, limit, modified_since, offset, order_by, series_type, start_year, stories, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_series_collection") get_series_collection

> Fetches lists of series.

```python
def get_series_collection(self,
                              characters=None,
                              comics=None,
                              contains='comic',
                              creators=None,
                              events=None,
                              limit=None,
                              modified_since=None,
                              offset=None,
                              order_by='title',
                              series_type='collection',
                              start_year=None,
                              stories=None,
                              title=None,
                              title_starts_with=None)
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

```python
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

result = series_client.get_series_collection(characters, comics, contains, creators, events, limit, modified_since, offset, order_by, series_type, start_year, stories, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_story_series_collection"></a>![Method: ](https://apidocs.io/img/method.png ".SeriesController.get_story_series_collection") get_story_series_collection

> Fetches lists of series filtered by a story id.

```python
def get_story_series_collection(self,
                                    story_id,
                                    characters=None,
                                    comics=None,
                                    contains='comic',
                                    creators=None,
                                    events=None,
                                    limit=None,
                                    modified_since=None,
                                    offset=None,
                                    order_by='title',
                                    series_type='collection',
                                    start_year=None,
                                    title=None,
                                    title_starts_with=None)
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

```python
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

result = series_client.get_story_series_collection(story_id, characters, comics, contains, creators, events, limit, modified_since, offset, order_by, series_type, start_year, title, title_starts_with)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="stories_controller"></a>![Class: ](https://apidocs.io/img/class.png ".StoriesController") StoriesController

### Get controller instance

An instance of the ``` StoriesController ``` class can be accessed from the API Client.

```python
 stories_client = client.stories
```

### <a name="get_character_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_character_story_collection") get_character_story_collection

> Fetches lists of stories filtered by a character id.

```python
def get_character_story_collection(self,
                                       character_id,
                                       comics=None,
                                       creators=None,
                                       events=None,
                                       limit=None,
                                       modified_since=None,
                                       offset=None,
                                       order_by='id',
                                       series=None)
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

```python
character_id = 'characterId'
comics = 'comics'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories_client.get_character_story_collection(character_id, comics, creators, events, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_comic_story_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_comic_story_collection_by_comic_id") get_comic_story_collection_by_comic_id

> Fetches lists of stories filtered by a comic id.

```python
def get_comic_story_collection_by_comic_id(self,
                                               comic_id,
                                               characters=None,
                                               creators=None,
                                               events=None,
                                               limit=None,
                                               modified_since=None,
                                               offset=None,
                                               order_by='id',
                                               series=None)
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

```python
comic_id = 'comicId'
characters = 'characters'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories_client.get_comic_story_collection_by_comic_id(comic_id, characters, creators, events, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_creator_story_collection") get_creator_story_collection

> Fetches lists of stories filtered by a creator id.

```python
def get_creator_story_collection(self,
                                     creator_id,
                                     characters=None,
                                     comics=None,
                                     events=None,
                                     limit=None,
                                     modified_since=None,
                                     offset=None,
                                     order_by='id',
                                     series=None)
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

```python
creator_id = 'creatorId'
characters = 'characters'
comics = 'comics'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories_client.get_creator_story_collection(creator_id, characters, comics, events, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_story_individual"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_story_individual") get_story_individual

> Fetches a single comic story by id.

```python
def get_story_individual(self,
                             story_id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| storyId |  ``` Required ```  | Filter by story id. |



#### Example Usage

```python
story_id = 'storyId'

result = stories_client.get_story_individual(story_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Story not found. |




### <a name="get_event_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_event_story_collection") get_event_story_collection

> Fetches lists of stories filtered by an event id.

```python
def get_event_story_collection(self,
                                   event_id,
                                   characters=None,
                                   comics=None,
                                   creators=None,
                                   limit=None,
                                   modified_since=None,
                                   offset=None,
                                   order_by='id',
                                   series=None)
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

```python
event_id = 'eventId'
characters = 'characters'
comics = 'comics'
creators = 'creators'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories_client.get_event_story_collection(event_id, characters, comics, creators, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_series_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_series_story_collection") get_series_story_collection

> Fetches lists of stories filtered by a series id.

```python
def get_series_story_collection(self,
                                    series_id,
                                    characters=None,
                                    comics=None,
                                    creators=None,
                                    events=None,
                                    limit=None,
                                    modified_since=None,
                                    offset=None,
                                    order_by='id')
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

```python
series_id = 'seriesId'
characters = 'characters'
comics = 'comics'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'

result = stories_client.get_series_story_collection(series_id, characters, comics, creators, events, limit, modified_since, offset, order_by)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_story_collection"></a>![Method: ](https://apidocs.io/img/method.png ".StoriesController.get_story_collection") get_story_collection

> Fetches lists of stories.

```python
def get_story_collection(self,
                             characters=None,
                             comics=None,
                             creators=None,
                             events=None,
                             limit=None,
                             modified_since=None,
                             offset=None,
                             order_by='id',
                             series=None)
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

```python
characters = 'characters'
comics = 'comics'
creators = 'creators'
events = 'events'
limit = 'limit'
modified_since = 'modifiedSince'
offset = 'offset'
order_by = 'id'
series = 'series'

result = stories_client.get_story_collection(characters, comics, creators, events, limit, modified_since, offset, order_by, series)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)

## <a name="creators_controller"></a>![Class: ](https://apidocs.io/img/class.png ".CreatorsController") CreatorsController

### Get controller instance

An instance of the ``` CreatorsController ``` class can be accessed from the API Client.

```python
 creators_client = client.creators
```

### <a name="get_creator_collection_by_comic_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection_by_comic_id") get_creator_collection_by_comic_id

> Fetches lists of creators filtered by a comic id.

```python
def get_creator_collection_by_comic_id(self,
                                           comic_id,
                                           comics=None,
                                           first_name=None,
                                           first_name_starts_with=None,
                                           last_name=None,
                                           last_name_starts_with=None,
                                           limit=None,
                                           middle_name=None,
                                           middle_name_starts_with=None,
                                           modified_since=None,
                                           name_starts_with=None,
                                           offset=None,
                                           order_by='lastName',
                                           series=None,
                                           stories=None,
                                           suffix=None)
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

```python
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

result = creators_client.get_creator_collection_by_comic_id(comic_id, comics, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, series, stories, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_collection"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection") get_creator_collection

> Fetches lists of creators.

```python
def get_creator_collection(self,
                               comics=None,
                               events=None,
                               first_name=None,
                               first_name_starts_with=None,
                               last_name=None,
                               last_name_starts_with=None,
                               limit=None,
                               middle_name=None,
                               middle_name_starts_with=None,
                               modified_since=None,
                               name_starts_with=None,
                               offset=None,
                               order_by='lastName',
                               series=None,
                               stories=None,
                               suffix=None)
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

```python
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

result = creators_client.get_creator_collection(comics, events, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, series, stories, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_individual"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_individual") get_creator_individual

> Fetches a single creator by id.

```python
def get_creator_individual(self,
                               creator_id)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| creatorId |  ``` Required ```  | A single creator id. |



#### Example Usage

```python
creator_id = 'creatorId'

result = creators_client.get_creator_individual(creator_id)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 404 | Creator not found. |




### <a name="get_creator_collection_by_event_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection_by_event_id") get_creator_collection_by_event_id

> Fetches lists of creators filtered by an event id.

```python
def get_creator_collection_by_event_id(self,
                                           event_id,
                                           comics=None,
                                           first_name=None,
                                           first_name_starts_with=None,
                                           last_name=None,
                                           last_name_starts_with=None,
                                           limit=None,
                                           middle_name=None,
                                           middle_name_starts_with=None,
                                           modified_since=None,
                                           name_starts_with=None,
                                           offset=None,
                                           order_by='lastName',
                                           series=None,
                                           stories=None,
                                           suffix=None)
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

```python
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

result = creators_client.get_creator_collection_by_event_id(event_id, comics, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, series, stories, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_collection_by_series_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection_by_series_id") get_creator_collection_by_series_id

> Fetches lists of creators filtered by a series id.

```python
def get_creator_collection_by_series_id(self,
                                            series_id,
                                            comics=None,
                                            events=None,
                                            first_name=None,
                                            first_name_starts_with=None,
                                            last_name=None,
                                            last_name_starts_with=None,
                                            limit=None,
                                            middle_name=None,
                                            middle_name_starts_with=None,
                                            modified_since=None,
                                            name_starts_with=None,
                                            offset=None,
                                            order_by='lastName',
                                            stories=None,
                                            suffix=None)
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

```python
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

result = creators_client.get_creator_collection_by_series_id(series_id, comics, events, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, stories, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




### <a name="get_creator_collection_by_story_id"></a>![Method: ](https://apidocs.io/img/method.png ".CreatorsController.get_creator_collection_by_story_id") get_creator_collection_by_story_id

> Fetches lists of creators filtered by a story id.

```python
def get_creator_collection_by_story_id(self,
                                           story_id,
                                           comics=None,
                                           events=None,
                                           first_name=None,
                                           first_name_starts_with=None,
                                           last_name=None,
                                           last_name_starts_with=None,
                                           limit=None,
                                           middle_name=None,
                                           middle_name_starts_with=None,
                                           modified_since=None,
                                           name_starts_with=None,
                                           offset=None,
                                           order_by='lastName',
                                           series=None,
                                           suffix=None)
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

```python
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

result = creators_client.get_creator_collection_by_story_id(story_id, comics, events, first_name, first_name_starts_with, last_name, last_name_starts_with, limit, middle_name, middle_name_starts_with, modified_since, name_starts_with, offset, order_by, series, suffix)

```

#### Errors

| Error Code | Error Description |
|------------|-------------------|
| 409 | Limit greater than 100. |




[Back to List of Controllers](#list_of_controllers)



