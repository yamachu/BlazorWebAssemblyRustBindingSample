EMENV=../../../../emscripten-core/emsdk/emsdk_env.sh

.PHONY: setup/rust-wasm publish/wasm
setup/rust-wasm:
	rustup target add wasm32-unknown-emscripten

publish/wasm: $(EMENV)
	. $(EMENV); cargo build --target=wasm32-unknown-emscripten --release

publish/header:
	cbindgen --config cbindgen.toml --crate sample --output target/libsample.h --lang c
