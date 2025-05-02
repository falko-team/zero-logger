FROM ubuntu:24.04

USER root

RUN apt-get update && apt-get install -y zlib1g ca-certificates curl wget gnupg apt-transport-https software-properties-common clang gcc unzip

RUN curl -SL https://dot.net/v1/dotnet-install.sh -o dotnet-install.sh && chmod +x dotnet-install.sh

RUN ./dotnet-install.sh --channel 10.0 --install-dir /usr/share/dotnet
RUN ./dotnet-install.sh --channel 9.0 --install-dir /usr/share/dotnet
RUN ./dotnet-install.sh --channel 8.0 --install-dir /usr/share/dotnet

ENV DOTNET_ROOT=/usr/share/dotnet
ENV PATH="$DOTNET_ROOT:$PATH"

COPY . /app

WORKDIR /app/Benchmarks/Falko.ZeroLogger.Benchmarks

CMD ["dotnet", "run", "-c", "Release", "-f", "net9.0"]
