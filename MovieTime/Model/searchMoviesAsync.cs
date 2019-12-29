using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MovieTime.Model
{

 /*   poster 
        backdrop*/
                                     /*   <Image Source = "{Binding Backdrop}" Stretch="UniformToFill"/>*/

    public class searchMoviesAsync : PagedResult<Movie>
    {

    }
    [DataContract]
    public abstract class Resource
    {
        [DataMember(Name = "id")]
        public int Id { get; internal set; }
    }

    public class Resources : PagedResult<Resource>
    {
    }
  
    [DataContract]
    public class Collection
    {
        [DataMember(Name = "id")]
        public int Id { get; internal set; }

        [DataMember(Name = "name")]
        public string Name { get; internal set; }

        [DataMember(Name = "poster_path")]
        public string Poster { get; internal set; }

        [DataMember(Name = "backdrop_path")]
        public string Backdrop { get; internal set; }

       /* [DataMember(Name = "parts")]
        public IEnumerable<Movie> Parts { get; internal set; }*/
    }

    public class Collections : PagedResult<Collection>
    {
    }

    [DataContract]
    public class Movie : Resource
    {
        [DataMember(Name = "title")]
        public string Title { get; internal set; }

        [DataMember(Name = "original_title")]
        public string OriginalTitle { get; internal set; }

        [DataMember(Name = "tagline")]
        public string TagLine { get; internal set; }

        [DataMember(Name = "overview")]
        public string Overview { get; internal set; }

        [DataMember(Name = "poster_path")]
        public string Poster { get; internal set; }

        [DataMember(Name = "backdrop_path")]
        public string Backdrop { get; internal set; }

        [DataMember(Name = "adult")]
        public bool Adult { get; internal set; }

        [DataMember(Name = "belongs_to_collection")]
        public Collection BelongsTo { get; internal set; }

        [DataMember(Name = "budget")]
        public int Budget { get; internal set; }

    /*    [DataMember(Name = "genres")]
        public IEnumerable<Genre> Genres { get; internal set; }*/

        [DataMember(Name = "homepage")]
        public string HomePage { get; internal set; }

        [DataMember(Name = "imdb_id")]
        public string Imdb { get; internal set; }

       /* [DataMember(Name = "production_companies")]
        public IEnumerable<Company> Companies { get; internal set; }*/

       /* [DataMember(Name = "production_countries")]
        public IEnumerable<Country> Countries { get; internal set; }*/

        [DataMember(Name = "release_date")]
        public DateTime? ReleaseDate { get; internal set; }

        [DataMember(Name = "revenue")]
        public Int64 Revenue { get; internal set; }

        [DataMember(Name = "runtime")]
        public int? Runtime { get; internal set; }

       /* [DataMember(Name = "spoken_languages")]
        public IEnumerable<Language> Languages { get; internal set; }

        [DataMember(Name = "alternative_titles")]
        public AlternativeTitles AlternativeTitles { get; internal set; }

        [DataMember(Name = "credits")]
        public MediaCredits Credits { get; internal set; }*/

    /*    [DataMember(Name = "images")]
        public Images Images { get; internal set; }

        [DataMember(Name = "videos")]
        public Videos Videos { get; internal set; }

        [DataMember(Name = "keywords")]
        public Keywords Keywords { get; internal set; }

        [DataMember(Name = "releases")]
        public Releases Releases { get; internal set; }

        [DataMember(Name = "translations")]
        public Translations Translations { get; internal set; }*/

        [DataMember(Name = "popularity")]
        public decimal Popularity { get; internal set; }

        [DataMember(Name = "vote_average")]
        public decimal VoteAverage { get; internal set; }

        [DataMember(Name = "vote_count")]
        public int VoteCount { get; internal set; }

        [DataMember(Name = "status")]
        public string Status { get; internal set; }

     /*   [DataMember(Name = "external_ids")]
        public ExternalIds External { get; internal set; }*/

    }

    public class Movies : PagedResult<Movie>
    {
    }

    [DataContract]
    public abstract class PagedResult<T>
{
        [DataMember(Name = "results")]
        public IEnumerable<T> Results { get; internal set; }

        [DataMember(Name = "page")]
        public int PageIndex { get; internal set; }

        [DataMember(Name = "total_pages")]
        public int PageCount { get; internal set; }

        [DataMember(Name = "total_results")]
        public int TotalCount { get; internal set; }
    }
}
