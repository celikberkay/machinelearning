// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers.FastTree;

namespace Microsoft.ML
{
    /// <summary>
    /// Tree <see cref="TrainCatalogBase"/> extension methods.
    /// </summary>
    public static class TreeExtensions
    {
        /// <summary>
        /// Predict a target using a decision tree regression model trained with the <see cref="FastTreeRegressionTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="RegressionCatalog"/>.</param>
        /// <param name="labelColumn">The label column.</param>
        /// <param name="featureColumn">The feature column.</param>
        /// <param name="weights">The optional weights column.</param>
        /// <param name="numTrees">Total number of decision trees to create in the ensemble.</param>
        /// <param name="numLeaves">The maximum number of leaves per decision tree.</param>
        /// <param name="minDatapointsInLeaves">The minimal number of datapoints allowed in a leaf of a regression tree, out of the subsampled data.</param>
        /// <param name="learningRate">The learning rate.</param>
        public static FastTreeRegressionTrainer FastTree(this RegressionCatalog.RegressionTrainers catalog,
            string labelColumn = DefaultColumnNames.Label,
            string featureColumn = DefaultColumnNames.Features,
            string weights = null,
            int numLeaves = Defaults.NumLeaves,
            int numTrees = Defaults.NumTrees,
            int minDatapointsInLeaves = Defaults.MinDocumentsInLeaves,
            double learningRate = Defaults.LearningRates)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastTreeRegressionTrainer(env, labelColumn, featureColumn, weights, numLeaves, numTrees, minDatapointsInLeaves, learningRate);
        }

        /// <summary>
        /// Predict a target using a decision tree regression model trained with the <see cref="FastTreeRegressionTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="RegressionCatalog"/>.</param>
        /// <param name="options">Algorithm advanced settings.</param>
        public static FastTreeRegressionTrainer FastTree(this RegressionCatalog.RegressionTrainers catalog,
            FastTreeRegressionTrainer.Options options)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            Contracts.CheckValue(options, nameof(options));

            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastTreeRegressionTrainer(env, options);
        }

        /// <summary>
        /// Predict a target using a decision tree binary classification model trained with the <see cref="FastTreeBinaryClassificationTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="BinaryClassificationCatalog"/>.</param>
        /// <param name="labelColumn">The labelColumn column.</param>
        /// <param name="featureColumn">The featureColumn column.</param>
        /// <param name="weights">The optional weights column.</param>
        /// <param name="numTrees">Total number of decision trees to create in the ensemble.</param>
        /// <param name="numLeaves">The maximum number of leaves per decision tree.</param>
        /// <param name="minDatapointsInLeaves">The minimal number of datapoints allowed in a leaf of the tree, out of the subsampled data.</param>
        /// <param name="learningRate">The learning rate.</param>
        public static FastTreeBinaryClassificationTrainer FastTree(this BinaryClassificationCatalog.BinaryClassificationTrainers catalog,
            string labelColumn = DefaultColumnNames.Label,
            string featureColumn = DefaultColumnNames.Features,
            string weights = null,
            int numLeaves = Defaults.NumLeaves,
            int numTrees = Defaults.NumTrees,
            int minDatapointsInLeaves = Defaults.MinDocumentsInLeaves,
            double learningRate = Defaults.LearningRates)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastTreeBinaryClassificationTrainer(env, labelColumn, featureColumn, weights, numLeaves, numTrees, minDatapointsInLeaves, learningRate);
        }

        /// <summary>
        /// Predict a target using a decision tree binary classification model trained with the <see cref="FastTreeBinaryClassificationTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="BinaryClassificationCatalog"/>.</param>
        /// <param name="options">Algorithm advanced settings.</param>
        public static FastTreeBinaryClassificationTrainer FastTree(this BinaryClassificationCatalog.BinaryClassificationTrainers catalog,
            FastTreeBinaryClassificationTrainer.Options options)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            Contracts.CheckValue(options, nameof(options));

            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastTreeBinaryClassificationTrainer(env, options);
        }

        /// <summary>
        /// Ranks a series of inputs based on their relevance, training a decision tree ranking model through the <see cref="FastTreeRankingTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="RankingCatalog"/>.</param>
        /// <param name="labelColumn">The labelColumn column.</param>
        /// <param name="featureColumn">The featureColumn column.</param>
        /// <param name="groupId">The groupId column.</param>
        /// <param name="weights">The optional weights column.</param>
        /// <param name="numTrees">Total number of decision trees to create in the ensemble.</param>
        /// <param name="numLeaves">The maximum number of leaves per decision tree.</param>
        /// <param name="minDatapointsInLeaves">The minimal number of datapoints allowed in a leaf of the tree, out of the subsampled data.</param>
        /// <param name="learningRate">The learning rate.</param>
        public static FastTreeRankingTrainer FastTree(this RankingCatalog.RankingTrainers catalog,
            string labelColumn = DefaultColumnNames.Label,
            string featureColumn = DefaultColumnNames.Features,
            string groupId = DefaultColumnNames.GroupId,
            string weights = null,
            int numLeaves = Defaults.NumLeaves,
            int numTrees = Defaults.NumTrees,
            int minDatapointsInLeaves = Defaults.MinDocumentsInLeaves,
            double learningRate = Defaults.LearningRates)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastTreeRankingTrainer(env, labelColumn, featureColumn, groupId, weights, numLeaves, numTrees, minDatapointsInLeaves, learningRate);
        }

        /// <summary>
        /// Ranks a series of inputs based on their relevance, training a decision tree ranking model through the <see cref="FastTreeRankingTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="RankingCatalog"/>.</param>
        /// <param name="options">Algorithm advanced settings.</param>
        public static FastTreeRankingTrainer FastTree(this RankingCatalog.RankingTrainers catalog,
            FastTreeRankingTrainer.Options options)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            Contracts.CheckValue(options, nameof(options));

            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastTreeRankingTrainer(env, options);
        }

        /// <summary>
        /// Predict a target using generalized additive models trained with the <see cref="BinaryClassificationGamTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="BinaryClassificationCatalog"/>.</param>
        /// <param name="labelColumn">The labelColumn column.</param>
        /// <param name="featureColumn">The featureColumn column.</param>
        /// <param name="weights">The optional weights column.</param>
        /// <param name="numIterations">The number of iterations to use in learning the features.</param>
        /// <param name="learningRate">The learning rate. GAMs work best with a small learning rate.</param>
        /// <param name="maxBins">The maximum number of bins to use to approximate features.</param>
        /// <param name="advancedSettings">Algorithm advanced settings.</param>
        public static BinaryClassificationGamTrainer GeneralizedAdditiveModels(this BinaryClassificationCatalog.BinaryClassificationTrainers catalog,
            string labelColumn = DefaultColumnNames.Label,
            string featureColumn = DefaultColumnNames.Features,
            string weights = null,
            int numIterations = GamDefaults.NumIterations,
            double learningRate = GamDefaults.LearningRates,
            int maxBins = GamDefaults.MaxBins,
            Action<BinaryClassificationGamTrainer.Arguments> advancedSettings = null)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            var env = CatalogUtils.GetEnvironment(catalog);
            return new BinaryClassificationGamTrainer(env, labelColumn, featureColumn, weights, numIterations, learningRate, maxBins, advancedSettings);
        }

        /// <summary>
        /// Predict a target using generalized additive models trained with the <see cref="RegressionGamTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="RegressionCatalog"/>.</param>
        /// <param name="labelColumn">The labelColumn column.</param>
        /// <param name="featureColumn">The featureColumn column.</param>
        /// <param name="weights">The optional weights column.</param>
        /// <param name="numIterations">The number of iterations to use in learning the features.</param>
        /// <param name="learningRate">The learning rate. GAMs work best with a small learning rate.</param>
        /// <param name="maxBins">The maximum number of bins to use to approximate features.</param>
        /// <param name="advancedSettings">Algorithm advanced settings.</param>
        public static RegressionGamTrainer GeneralizedAdditiveModels(this RegressionCatalog.RegressionTrainers catalog,
            string labelColumn = DefaultColumnNames.Label,
            string featureColumn = DefaultColumnNames.Features,
            string weights = null,
            int numIterations = GamDefaults.NumIterations,
            double learningRate = GamDefaults.LearningRates,
            int maxBins = GamDefaults.MaxBins,
            Action<RegressionGamTrainer.Arguments> advancedSettings = null)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            var env = CatalogUtils.GetEnvironment(catalog);
            return new RegressionGamTrainer(env, labelColumn, featureColumn, weights, numIterations, learningRate, maxBins, advancedSettings);
        }

        /// <summary>
        /// Predict a target using a decision tree regression model trained with the <see cref="FastTreeTweedieTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="RegressionCatalog"/>.</param>
        /// <param name="labelColumn">The labelColumn column.</param>
        /// <param name="featureColumn">The featureColumn column.</param>
        /// <param name="weights">The optional weights column.</param>
        /// <param name="numTrees">Total number of decision trees to create in the ensemble.</param>
        /// <param name="numLeaves">The maximum number of leaves per decision tree.</param>
        /// <param name="minDatapointsInLeaves">The minimal number of datapoints allowed in a leaf of the tree, out of the subsampled data.</param>
        /// <param name="learningRate">The learning rate.</param>
        public static FastTreeTweedieTrainer FastTreeTweedie(this RegressionCatalog.RegressionTrainers catalog,
            string labelColumn = DefaultColumnNames.Label,
            string featureColumn = DefaultColumnNames.Features,
            string weights = null,
            int numLeaves = Defaults.NumLeaves,
            int numTrees = Defaults.NumTrees,
            int minDatapointsInLeaves = Defaults.MinDocumentsInLeaves,
            double learningRate = Defaults.LearningRates)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastTreeTweedieTrainer(env, labelColumn, featureColumn, weights, numLeaves, numTrees, minDatapointsInLeaves, learningRate);
        }

        /// <summary>
        /// Predict a target using a decision tree regression model trained with the <see cref="FastTreeTweedieTrainer"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="RegressionCatalog"/>.</param>
        /// <param name="options">Algorithm advanced settings.</param>
        public static FastTreeTweedieTrainer FastTreeTweedie(this RegressionCatalog.RegressionTrainers catalog,
            FastTreeTweedieTrainer.Options options)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            Contracts.CheckValue(options, nameof(options));

            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastTreeTweedieTrainer(env, options);
        }

        /// <summary>
        /// Predict a target using a decision tree regression model trained with the <see cref="FastForestRegression"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="RegressionCatalog"/>.</param>
        /// <param name="labelColumn">The labelColumn column.</param>
        /// <param name="featureColumn">The featureColumn column.</param>
        /// <param name="weights">The optional weights column.</param>
        /// <param name="numTrees">Total number of decision trees to create in the ensemble.</param>
        /// <param name="numLeaves">The maximum number of leaves per decision tree.</param>
        /// <param name="minDatapointsInLeaves">The minimal number of datapoints allowed in a leaf of the tree, out of the subsampled data.</param>
        /// <param name="learningRate">The learning rate.</param>
        public static FastForestRegression FastForest(this RegressionCatalog.RegressionTrainers catalog,
            string labelColumn = DefaultColumnNames.Label,
            string featureColumn = DefaultColumnNames.Features,
            string weights = null,
            int numLeaves = Defaults.NumLeaves,
            int numTrees = Defaults.NumTrees,
            int minDatapointsInLeaves = Defaults.MinDocumentsInLeaves,
            double learningRate = Defaults.LearningRates)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastForestRegression(env, labelColumn, featureColumn, weights, numLeaves, numTrees, minDatapointsInLeaves, learningRate);
        }

        /// <summary>
        /// Predict a target using a decision tree regression model trained with the <see cref="FastForestRegression"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="RegressionCatalog"/>.</param>
        /// <param name="options">Algorithm advanced settings.</param>
        public static FastForestRegression FastForest(this RegressionCatalog.RegressionTrainers catalog,
            FastForestRegression.Options options)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            Contracts.CheckValue(options, nameof(options));

            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastForestRegression(env, options);
        }

        /// <summary>
        /// Predict a target using a decision tree regression model trained with the <see cref="FastForestClassification"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="BinaryClassificationCatalog"/>.</param>
        /// <param name="labelColumn">The labelColumn column.</param>
        /// <param name="featureColumn">The featureColumn column.</param>
        /// <param name="weights">The optional weights column.</param>
        /// <param name="numTrees">Total number of decision trees to create in the ensemble.</param>
        /// <param name="numLeaves">The maximum number of leaves per decision tree.</param>
        /// <param name="minDatapointsInLeaves">The minimal number of datapoints allowed in a leaf of the tree, out of the subsampled data.</param>
        /// <param name="learningRate">The learning rate.</param>
        public static FastForestClassification FastForest(this BinaryClassificationCatalog.BinaryClassificationTrainers catalog,
            string labelColumn = DefaultColumnNames.Label,
            string featureColumn = DefaultColumnNames.Features,
            string weights = null,
            int numLeaves = Defaults.NumLeaves,
            int numTrees = Defaults.NumTrees,
            int minDatapointsInLeaves = Defaults.MinDocumentsInLeaves,
            double learningRate = Defaults.LearningRates)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastForestClassification(env, labelColumn, featureColumn, weights,numLeaves, numTrees, minDatapointsInLeaves, learningRate);
        }

        /// <summary>
        /// Predict a target using a decision tree regression model trained with the <see cref="FastForestClassification"/>.
        /// </summary>
        /// <param name="catalog">The <see cref="BinaryClassificationCatalog"/>.</param>
        /// <param name="options">Algorithm advanced settings.</param>
        public static FastForestClassification FastForest(this BinaryClassificationCatalog.BinaryClassificationTrainers catalog,
            FastForestClassification.Options options)
        {
            Contracts.CheckValue(catalog, nameof(catalog));
            Contracts.CheckValue(options, nameof(options));

            var env = CatalogUtils.GetEnvironment(catalog);
            return new FastForestClassification(env, options);
        }
    }
}
