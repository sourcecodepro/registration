
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// builder.Services.AddRazorPages()
//     .AddRazorRuntimeCompilation();

// builder.Services.AddAuthentication().AddCookie("UserCookieAuth", options => {
//     options.Cookie.Name = "UserCookieAuth";

// });

//authenticates without specifying addauthentication parameter
builder.Services.AddAuthentication("UserCookieAuth").AddCookie("UserCookieAuth", options => {
    options.Cookie.Name = "UserCookieAuth";
    options.LoginPath = "/User/Login";
    options.AccessDeniedPath = "/User/AccessDenied";
    options.ExpireTimeSpan = TimeSpan.FromHours(12);

});

builder.Services.AddAuthorization(options => {

    options.AddPolicy("AdminsOnly", policy => 
        policy.RequireClaim("Role", "Admin"));

});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

//authenticates without UseAuthentication() declaration
app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
