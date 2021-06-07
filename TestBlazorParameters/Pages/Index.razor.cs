using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBlazorParameters.Shared;

namespace TestBlazorParameters.Pages
{
	public partial class Index : ComponentBase
	{
		private RenderFragment renderFragment;

		private void OnTest()
		{
			StateHasChanged();
		}

		protected override void OnInitialized()
		{
			renderFragment = new RenderFragment(builder =>
			{
				var i = 0;
				builder.OpenComponent(i++, typeof(SurveyPrompt));
				builder.AddAttribute(i++, nameof(SurveyPrompt.Title), "test");
				builder.AddAttribute(i++, nameof(SurveyPrompt.OnTest), (Action)OnTest);
				builder.CloseComponent();
			});
		}
	}
}
