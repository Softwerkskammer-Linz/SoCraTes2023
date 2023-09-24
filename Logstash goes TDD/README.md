# Logstash goes TDD

  [logstash-tdd @github](https://github.com/maosmurf/logstash-tdd)

Expectations
* How to bring TDD into Logstash
* What is the point of view on Logstash?
    * Declarative over
    * vs. Loki/Kafka/...

* What does a user of OSS expect (the maintainer to put)
    * examples?
    * docs?

* How to address Docker from a test setup?
    * NodeJs - Dockerode
    * Python?
    * Java? -> testcontainers

* Advantages
    * Direct feedback, as logstash files are solely linked in, does not require restart of the container

How important is fast feedback for TDD?
-> it's essential (within secods)

* What data to write TDD on?
    * New requirement triggers a new test
    * It's about engineering test data
    * Developer/engineer becomes data engineer on your own test data

* Breaks property based testing

* TDD changes, see also session [different schools of TDD](https://www.tddstpau.li/)
