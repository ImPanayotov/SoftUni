﻿namespace WebHunt
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            string Κωδικόςπρόσβασης = @"Αν επιθυμείτε να διατηρήσετε στη αιωνιότητα παλαιά και σπάνια βιβλία 2289 
                                        (ακόμα και ασήμων συγγραφέων) τα 24grammata.com σας δίνουν τη δυνατότητα. 
                                        Aν είστε δικαιούχος ή απλώς έχετε στη βιβλιοθήκη σας παλαιά βιβλία 
                                        (άνω των 70 ετών, ή από εκδοτικούς οίκους που έκλεισαν) σαρώστε τα (scanner) 
                                        και στείλτετά σε μορφή pdf (η σάρωση μπορεί να γίνει και σε ένα φωτοτυπείο). 
                                        Καλό είναι να συνοδευεται και με ένα κείμενο (τουλάχιστον 5-10γραμμές) που θα 
                                        ενημερώνει για τον συγγραφέα, το έργο ή τον αποστολέα. Contest Τα 24grammata.com 
                                        θα τα δημοσιεύσουν στη στήλη free ebooks – σπάνια ή παλαιά βιβλία. Μοναδικός σκοπός 
                                        είναι να διατηρηθεί στην αιωνιότητα η πνευματική δημιουργία του παρελθόντος.
                                        * δεν υπόκεινται στις δεσμεύσεις περί πνευματικών δικαιωμάτων(οι συγγραφείς τα 
                                        έστειλαν απευθείας στα 24grammata.com, ή έχουν παρέλθει 70 έτη από το θάνατο του 
                                        συγγραφέα, ή δε διεκδικούνται τα δικαιώματα από τους δικαιούχους). Σε περίπτωση που 
                                        οι δικαιούχοι αλλάξουν γνώμη τα 24grammata.com δεσμεύονται να αποσύρουν άμεσα το ebook.
                                        Έ 'radecast' γινε μια αυστηρή επιλογή ανάμεσα σε αξιόλογα βιβλία. Δεν πρόκειται για μία 
                                        απλή μεταφόρτωση συνδέσμου.Oι συνεργάτες του 24grammata.com εργάζονται καθημερινά, με 
                                        δικά τους έξοδα, να σαρώσουν, να προλογίσουν και να παρουσιάσουν με μοναδικό και καλαίσθητο
                                        τρόπο ό,τι το αξιόλογο από την ελληνική, αγγλική και ιταλική λογοτεχνία. ";
            Console.WriteLine(Κωδικόςπρόσβασης);
        }
    }
}