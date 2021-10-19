--
-- PostgreSQL database dump
--

-- Dumped from database version 12.6
-- Dumped by pg_dump version 13.2

-- Started on 2021-08-16 15:21:22

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 203 (class 1259 OID 21742)
-- Name: t_dataimport_summary; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.t_dataimport_summary (
    id character varying(64) NOT NULL,
    remark character varying(1024),
    createtime timestamp without time zone NOT NULL,
    filecount integer NOT NULL,
    files text[],
    importstatus text
);


ALTER TABLE public.t_dataimport_summary OWNER TO postgres;

--
-- TOC entry 3804 (class 2606 OID 21749)
-- Name: t_dataimport_summary pk_t_dataimport_summary; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.t_dataimport_summary
    ADD CONSTRAINT pk_t_dataimport_summary PRIMARY KEY (id);


-- Completed on 2021-08-16 15:21:22

--
-- PostgreSQL database dump complete
--

