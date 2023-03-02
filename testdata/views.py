from django.http import HttpResponse
from django.shortcuts import render

def about(request):
    return render(request, 'about.html')

def generator(request):
    return render(request, 'generator.html')