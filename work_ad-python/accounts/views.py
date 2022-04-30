from django.contrib.auth.forms import UserCreationForm
from django.urls import reverse_lazy
from django.views import generic

class SignUpView(generic.CreateView):
  form_class = UserCreationForm
  success_url = reverse_lazy('login')
  template_name = 'registration/signup.html'

#template_nameは登録画面のHTMLファイル名を指定
#success_urlは登録完了後のリダイレクト先のURLを指定
