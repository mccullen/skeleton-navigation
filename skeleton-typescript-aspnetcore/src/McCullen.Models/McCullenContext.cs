using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace McCullen.Models
{
    public class McCullenContext : DbContext
    {
		public McCullenContext(DbContextOptions<McCullenContext> options) : base(options)
		{
		}
    }
	public class Blog
	{
		public int BlogId { get; set; }
		public string Url { get; set; }
		public List<Post> Posts { get; set; }
	}

	public class Post
	{
		public int PostId { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public int BlogId { get; set; }
		public Blog Blog { get; set; }
	}
}
