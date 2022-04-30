from django.urls import path
from .views import SignUpView


urlpatterns = [
    path('signup/', SignUpView.as_view(), name='signup'),
]
#accounts/urls.pyの2行目の以下の記述はaccountsディレクトリ内にあるviews.pyのSignUpViewクラスを呼び出し。
#accounts/urls.pyのurlpatterns内の以下の記述はURLにsignup/を指定して、SignUpViewクラスを呼び出し。引数nameに'signup'を指定します。
