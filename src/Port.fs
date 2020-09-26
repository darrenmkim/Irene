[<AutoOpen>]

module Irene.Port

(*
open System
open System.Data.SQLite
open Fed.Fred

open Irene.Mock

let dbName = "db.sqlite"
let connInfo = sprintf "Data Source=%s;Version=3;" dbName  
SQLiteConnection.CreateFile(dbName)

let conn = new SQLiteConnection(connInfo)
conn.Open()

let structureSql =
    "create table Trades (" +
    "Symbol varchar(20), " +
    "Timestamp datetime, " + 
    "Price float, " + 
    "TradeSize float)"

let structureCommand = new SQLiteCommand(structureSql, conn)
structureCommand.ExecuteNonQuery() |> ignore

let getDealsByDates startDate endDate =
    mockdeals
    |> lfilt (fun d 
                -> d.TradeDate > startDate 
                || d.MatureDate < endDate)
    |> lmap (fun d -> d.Id)

let getDealById id = 
    mockdeals |> lfind (fun d -> d.Id = id) 
    
let getLegById id =
    mocklegs |> lfind (fun l -> l.Id = id) 

let getLegIdsByDealIds dealIds =
    mocklegs
    |> lfilt (fun l -> lcont l.DealId dealIds) 
    |> lmap (fun l -> l.Id)

let getRollById id = 
    mockrolls |> lfind (fun r -> r.Id = id) 

let getFreqById id = 
    FREQS |> lfind (fun e -> e.Id = id) 




// WORKING 
let getRate x =
    let fred = new Fed.Fred.Fred ("FRED API key")
    3





    Create a Fed.Fred object.

var fred = new Fred("FRED API key");

The library does not cache calls 
from the FRED database. You can change cache option.

var fred = new Fred("api key", RequestCacheLevel.BypassCache); //Default Option

Categories

GetCategory
var release = fred.GetCategory(int categoryId);

GetCategoryChildren
IEnumerable<Category> GetCategoryChildren(int categoryId);

GetCategoryRelated
IEnumerable<Category> GetCategoryRelated(int categoryId);

GetCategorySeries
IEnumerable<Series> GetCategorySeries(int seriesId);

GetCategoryTags
IEnumerable<Tags> GetCategoryTags(int categoryId);

GetCategoryRelatedTags
IEnumerable<Tags> GetCategoryRelatedTags(int categoryId);

Releases

GetReleases
IEnumerable<Release> releases = fred.GetReleases();
foreach (var release in releases){}

GetReleasesDates
IEnumerable<ReleaseDate> GetReleasesDates();

GetRelease
var release = fred.GetRelease(int releaseId);

GetReleaseDates
IEnumerable<ReleaseDate> GetReleaseDates(int releaseId);

GetReleaseSeries
IEnumerable<Series> GetReleaseSeries(int releaseId);

GetReleaseSources
IEnumerable<Series> GetReleaseSources(int releaseId);

GetReleaseTags
IEnumerable<Tags> GetReleaseTags(int releaseId);

GetReleaseRelatedTags
IEnumerable<Tags> GetReleaseRelatedTags(int releaseId);

Series

GetSeries
var release = fred.GetSeries(string seriesId);

GetSeriesCategories
IEnumerable<Category> GetSeriesCategories(string seriesId);

GetSeriesObservations
IEnumerable<Observation> GetSeriesObservations(string seriesId);

GetSeriesRelease
var series = fred.GetSeriesRelease(string seriesId);

GetSeriesSearch
IEnumerable<Series> GetSeriesSearch(string searchText);

GetSeriesSearchTags
IEnumerable<Tags> GetSeriesSearchTags(string searchText);

GetSeriesSearchRelatedTags
IEnumerable<Tags> GetSeriesSearchRelatedTags(string searchText, string tag_names);

GetSeriesTags
IEnumerable<Tags> GetSeriesTags(string seriesId);

GetSeriesUpdates
IEnumerable<Series> GetSeriesUpdates();

GetVintageDates
IEnumerable<VintageDate> GetVintageDates(string seriesId);

Sources

GetSources
IEnumerable<Source> GetSources();

GetSource
IEnumerable<Source> GetSource(int sourceID);

GetSourceReleases
IEnumerable<Source> GetSource(int sourceID);

Tags

GetTags
IEnumerable<Tags> GetTags();

GetRelatedTags
IEnumerable<Tags> GetSource(string tag_Names);

GetTagSeries
IEnumerable<Series> GetTagSeries(string tag_Names);


*)