#!/usr/bin/python
import requests
import json
import sys
import re
import wave

def main():
	txt = sys.argv[1]
	headers = {
		'Content-Type': 'text/plain', 
		'Accept': 'audio/x-wav'
	}
	url = 'https://tts.nuancemobility.net:443/NMDPTTSCmdServlet/tts?appId=%s&appKey=%s&voice=%s' % (
		"NMDPTRIAL_alexsmith1_me_com20151003091117", 
		"135048da39da7a888015d9d1d429b6eb3cd2f074e2e07facb0a766d308400b1b9054f6ca2e7052ae852b7f5955364591083505ea158497c62cfd99343da44fcd", 
		"Fiona")
	r = requests.post(url, data=txt, headers=headers)
	with open('./audio.wav', 'wb+') as f:
		f.write(r.content)

if __name__ == '__main__':
	main()
