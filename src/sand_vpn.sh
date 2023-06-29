#!/bin/bash

api="https://api.sandvpn.com"
user_agent="Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:108.0) Gecko/20100101 Firefox/108.0"

function get_proxies() {
	curl --request GET \
		--url "$api/proxys" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}

function get_unlock() {
	curl --request GET \
		--url "$api/unlock" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}
