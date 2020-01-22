using System;
using System.Collections.Generic;
using System.Runtime.Serialization;



/// <summary>
/// Funckcja asynchroniczna
/// </summary>
namespace MovieTime.Model
{


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

    /// <summary>
    /// Pobrana kolekcja 
    /// </summary>
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

    }

    public class Collections : PagedResult<Collection>
    {
    }
    /// <summary>
    /// Pobrane wartości których możemy użyć
    /// </summary>
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

        [DataMember(Name = "homepage")]
        public string HomePage { get; internal set; }

        [DataMember(Name = "imdb_id")]
        public string Imdb { get; internal set; }

        [DataMember(Name = "release_date")]
        public DateTime? ReleaseDate { get; internal set; }

        [DataMember(Name = "revenue")]
        public Int64 Revenue { get; internal set; }

        [DataMember(Name = "runtime")]
        public int? Runtime { get; internal set; }

        [DataMember(Name = "popularity")]
        public decimal Popularity { get; internal set; }

        [DataMember(Name = "vote_average")]
        public decimal VoteAverage { get; internal set; }

        [DataMember(Name = "vote_count")]
        public int VoteCount { get; internal set; }

        [DataMember(Name = "status")]
        public string Status { get; internal set; }


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
