using BlogSystemApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogSystemApp.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogDbContext dbContext;

        public BlogController(BlogDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Update(int blogId)
        {
            var blog = dbContext.Blogs.Find(blogId);
            // Perform some operations or display the blog data to the first user

            // Meanwhile, another user updates the same blog post
            var concurrentBlog = dbContext.Blogs.Find(blogId);
            concurrentBlog.Title = "Updated Title";
            concurrentBlog.Content = "Updated Content";

            // Save changes, which may cause a concurrency conflict
            try
            {
                dbContext.SaveChanges();
                // Success: Handle the update completion
                return RedirectToAction("Index", "Home"); // Redirect to a success page
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entry = ex.Entries.Single();
                var clientValues = (Blog)entry.Entity;
                var databaseValues = (Blog)entry.GetDatabaseValues().ToObject();

                // Provide feedback to the user about the conflict
                ViewBag.ConcurrencyErrorMessage = "Concurrency conflict detected. Please refresh the page and try again.";
                // You can use ViewData or TempData instead of ViewBag if desired

                // Optionally, resolve the conflict automatically or allow the user to decide
                entry.OriginalValues.SetValues(databaseValues);
                dbContext.SaveChanges();
                // Success: Handle the conflict resolution completion
                return RedirectToAction("Index", "Home"); // Redirect to a conflict resolution page
            }
        }
    }
}
