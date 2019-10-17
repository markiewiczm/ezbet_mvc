DROP Table public.bet;
DROP Table public.game;

CREATE TABLE public.game
(
    "ID" serial NOT NULL ,
    "Name" character varying NOT NULL,
    "BetStartDate" timestamp with time zone NOT NULL,
    "BetEndDate" timestamp with time zone NOT NULL,
    "GameState" character varying  NOT NULL,
    CONSTRAINT game_pkey PRIMARY KEY ("ID")
);

ALTER TABLE public.game
    OWNER to postgres;

CREATE TABLE public.bet
(
    "ID" serial NOT NULL,
    "Name" character varying  NOT NULL,
    "Score" character varying  NOT NULL,
    "GameID" bigint NOT NULL,
    "Type" character varying  NOT NULL,
    CONSTRAINT bet_pkey PRIMARY KEY ("ID"),
    CONSTRAINT fk_game_id_bet FOREIGN KEY ("GameID")
        REFERENCES public.game ("ID") 
        ON UPDATE NO ACTION
        ON DELETE CASCADE
);

ALTER TABLE public.bet
    OWNER to postgres;

INSERT INTO public.game(
	 "Name", "BetStartDate", "BetEndDate", "GameState")
	VALUES ('GAME_1', now(), now(), 'ACTIVE');

INSERT INTO public.bet(
	 "Name", "Type", "Score", "GameID")
	VALUES ('BET_1','EXACT','2:1', 1);