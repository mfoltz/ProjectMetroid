// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Leaderboards.LeaderboardsInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Leaderboards
{
  public sealed class LeaderboardsInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboarddefinitionbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboarddefinitionbyleaderboardidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboardrecordbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboardrecordbyuseridApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboarduserscorebyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyleaderboarduserscorebyuseridApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefinitionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetleaderboarddefinitioncountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetleaderboardrecordcountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetleaderboarduserscorecountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeaderboardrecordApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_LeaderboarduserscoreApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryleaderboarddefinitionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryleaderboardranksApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryleaderboarduserscoresApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeUndefined;
    private static readonly System.IntPtr NativeFieldInfoPtr_UserscoresquerystatinfoApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardDefinitionByIndex_Public_Result_byref_CopyLeaderboardDefinitionByIndexOptions_byref_Nullable_1_Definition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardDefinitionByLeaderboardId_Public_Result_byref_CopyLeaderboardDefinitionByLeaderboardIdOptions_byref_Nullable_1_Definition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardRecordByIndex_Public_Result_byref_CopyLeaderboardRecordByIndexOptions_byref_Nullable_1_LeaderboardRecord_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardRecordByUserId_Public_Result_byref_CopyLeaderboardRecordByUserIdOptions_byref_Nullable_1_LeaderboardRecord_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardUserScoreByIndex_Public_Result_byref_CopyLeaderboardUserScoreByIndexOptions_byref_Nullable_1_LeaderboardUserScore_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyLeaderboardUserScoreByUserId_Public_Result_byref_CopyLeaderboardUserScoreByUserIdOptions_byref_Nullable_1_LeaderboardUserScore_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardDefinitionCount_Public_UInt32_byref_GetLeaderboardDefinitionCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardRecordCount_Public_UInt32_byref_GetLeaderboardRecordCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLeaderboardUserScoreCount_Public_UInt32_byref_GetLeaderboardUserScoreCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryLeaderboardDefinitions_Public_Void_byref_QueryLeaderboardDefinitionsOptions_Object_OnQueryLeaderboardDefinitionsCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryLeaderboardRanks_Public_Void_byref_QueryLeaderboardRanksOptions_Object_OnQueryLeaderboardRanksCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryLeaderboardUserScores_Public_Void_byref_QueryLeaderboardUserScoresOptions_Object_OnQueryLeaderboardUserScoresCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryLeaderboardRanksCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryLeaderboardRanksCompleteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LeaderboardsInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958764, XrefRangeEnd = 958778, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLeaderboardDefinitionByIndex(
      ref CopyLeaderboardDefinitionByIndexOptions options,
      out Il2CppSystem.Nullable<Definition> outLeaderboardDefinition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardDefinitionByIndex_Public_Result_byref_CopyLeaderboardDefinitionByIndexOptions_byref_Nullable_1_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Definition> local = ref outLeaderboardDefinition;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Definition>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958778, XrefRangeEnd = 958792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLeaderboardDefinitionByLeaderboardId(
      ref CopyLeaderboardDefinitionByLeaderboardIdOptions options,
      out Il2CppSystem.Nullable<Definition> outLeaderboardDefinition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardDefinitionByLeaderboardId_Public_Result_byref_CopyLeaderboardDefinitionByLeaderboardIdOptions_byref_Nullable_1_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Definition> local = ref outLeaderboardDefinition;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Definition>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958792, XrefRangeEnd = 958806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLeaderboardRecordByIndex(
      ref CopyLeaderboardRecordByIndexOptions options,
      out Il2CppSystem.Nullable<LeaderboardRecord> outLeaderboardRecord)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardRecordByIndex_Public_Result_byref_CopyLeaderboardRecordByIndexOptions_byref_Nullable_1_LeaderboardRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<LeaderboardRecord> local = ref outLeaderboardRecord;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<LeaderboardRecord>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958806, XrefRangeEnd = 958820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLeaderboardRecordByUserId(
      ref CopyLeaderboardRecordByUserIdOptions options,
      out Il2CppSystem.Nullable<LeaderboardRecord> outLeaderboardRecord)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardRecordByUserId_Public_Result_byref_CopyLeaderboardRecordByUserIdOptions_byref_Nullable_1_LeaderboardRecord_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<LeaderboardRecord> local = ref outLeaderboardRecord;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<LeaderboardRecord>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958820, XrefRangeEnd = 958834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLeaderboardUserScoreByIndex(
      ref CopyLeaderboardUserScoreByIndexOptions options,
      out Il2CppSystem.Nullable<LeaderboardUserScore> outLeaderboardUserScore)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardUserScoreByIndex_Public_Result_byref_CopyLeaderboardUserScoreByIndexOptions_byref_Nullable_1_LeaderboardUserScore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<LeaderboardUserScore> local = ref outLeaderboardUserScore;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<LeaderboardUserScore>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958834, XrefRangeEnd = 958848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyLeaderboardUserScoreByUserId(
      ref CopyLeaderboardUserScoreByUserIdOptions options,
      out Il2CppSystem.Nullable<LeaderboardUserScore> outLeaderboardUserScore)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardUserScoreByUserId_Public_Result_byref_CopyLeaderboardUserScoreByUserIdOptions_byref_Nullable_1_LeaderboardUserScore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<LeaderboardUserScore> local = ref outLeaderboardUserScore;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<LeaderboardUserScore>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958848, XrefRangeEnd = 958856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetLeaderboardDefinitionCount(
      ref GetLeaderboardDefinitionCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardDefinitionCount_Public_UInt32_byref_GetLeaderboardDefinitionCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958856, XrefRangeEnd = 958864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetLeaderboardRecordCount(ref GetLeaderboardRecordCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardRecordCount_Public_UInt32_byref_GetLeaderboardRecordCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958864, XrefRangeEnd = 958872, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetLeaderboardUserScoreCount(ref GetLeaderboardUserScoreCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardUserScoreCount_Public_UInt32_byref_GetLeaderboardUserScoreCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958872, XrefRangeEnd = 958891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryLeaderboardDefinitions(
      ref QueryLeaderboardDefinitionsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryLeaderboardDefinitionsCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardDefinitions_Public_Void_byref_QueryLeaderboardDefinitionsOptions_Object_OnQueryLeaderboardDefinitionsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958891, XrefRangeEnd = 958910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryLeaderboardRanks(
      ref QueryLeaderboardRanksOptions options,
      Il2CppSystem.Object clientData,
      OnQueryLeaderboardRanksCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardRanks_Public_Void_byref_QueryLeaderboardRanksOptions_Object_OnQueryLeaderboardRanksCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958910, XrefRangeEnd = 958929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryLeaderboardUserScores(
      ref QueryLeaderboardUserScoresOptions options,
      Il2CppSystem.Object clientData,
      OnQueryLeaderboardUserScoresCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardUserScores_Public_Void_byref_QueryLeaderboardUserScoresOptions_Object_OnQueryLeaderboardUserScoresCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958929, XrefRangeEnd = 958936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation(
      ref OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958936, XrefRangeEnd = 958943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryLeaderboardRanksCompleteCallbackInternalImplementation(
      ref OnQueryLeaderboardRanksCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardRanksCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryLeaderboardRanksCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958943, XrefRangeEnd = 958950, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation(
      ref OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LeaderboardsInterface()
    {
      Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Leaderboards", nameof (LeaderboardsInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr);
      LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboarddefinitionbyindexApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyleaderboardidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboarddefinitionbyleaderboardidApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboardrecordbyindexApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboardrecordbyuseridApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboarduserscorebyindexApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyuseridApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (CopyleaderboarduserscorebyuseridApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_DefinitionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (DefinitionApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarddefinitioncountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (GetleaderboarddefinitioncountApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboardrecordcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (GetleaderboardrecordcountApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarduserscorecountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (GetleaderboarduserscorecountApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_LeaderboardrecordApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (LeaderboardrecordApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_LeaderboarduserscoreApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (LeaderboarduserscoreApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarddefinitionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (QueryleaderboarddefinitionsApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboardranksApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (QueryleaderboardranksApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarduserscoresApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (QueryleaderboarduserscoresApiLatest));
      LeaderboardsInterface.NativeFieldInfoPtr_TimeUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (TimeUndefined));
      LeaderboardsInterface.NativeFieldInfoPtr_UserscoresquerystatinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, nameof (UserscoresquerystatinfoApiLatest));
      LeaderboardsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670973);
      LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardDefinitionByIndex_Public_Result_byref_CopyLeaderboardDefinitionByIndexOptions_byref_Nullable_1_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670975);
      LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardDefinitionByLeaderboardId_Public_Result_byref_CopyLeaderboardDefinitionByLeaderboardIdOptions_byref_Nullable_1_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670976);
      LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardRecordByIndex_Public_Result_byref_CopyLeaderboardRecordByIndexOptions_byref_Nullable_1_LeaderboardRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670977);
      LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardRecordByUserId_Public_Result_byref_CopyLeaderboardRecordByUserIdOptions_byref_Nullable_1_LeaderboardRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670978);
      LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardUserScoreByIndex_Public_Result_byref_CopyLeaderboardUserScoreByIndexOptions_byref_Nullable_1_LeaderboardUserScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670979);
      LeaderboardsInterface.NativeMethodInfoPtr_CopyLeaderboardUserScoreByUserId_Public_Result_byref_CopyLeaderboardUserScoreByUserIdOptions_byref_Nullable_1_LeaderboardUserScore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670980);
      LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardDefinitionCount_Public_UInt32_byref_GetLeaderboardDefinitionCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670981);
      LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardRecordCount_Public_UInt32_byref_GetLeaderboardRecordCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670982);
      LeaderboardsInterface.NativeMethodInfoPtr_GetLeaderboardUserScoreCount_Public_UInt32_byref_GetLeaderboardUserScoreCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670983);
      LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardDefinitions_Public_Void_byref_QueryLeaderboardDefinitionsOptions_Object_OnQueryLeaderboardDefinitionsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670984);
      LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardRanks_Public_Void_byref_QueryLeaderboardRanksOptions_Object_OnQueryLeaderboardRanksCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670985);
      LeaderboardsInterface.NativeMethodInfoPtr_QueryLeaderboardUserScores_Public_Void_byref_QueryLeaderboardUserScoresOptions_Object_OnQueryLeaderboardUserScoresCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670986);
      LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryLeaderboardDefinitionsCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670987);
      LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardRanksCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryLeaderboardRanksCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670988);
      LeaderboardsInterface.NativeMethodInfoPtr_OnQueryLeaderboardUserScoresCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryLeaderboardUserScoresCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaderboardsInterface>.NativeClassPtr, 100670989);
    }

    public LeaderboardsInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CopyleaderboarddefinitionbyindexApiLatest
    {
      get
      {
        int copyleaderboarddefinitionbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyindexApiLatest, (void*) &copyleaderboarddefinitionbyindexApiLatest);
        return copyleaderboarddefinitionbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyleaderboarddefinitionbyleaderboardidApiLatest
    {
      get
      {
        int copyleaderboarddefinitionbyleaderboardidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyleaderboardidApiLatest, (void*) &copyleaderboarddefinitionbyleaderboardidApiLatest);
        return copyleaderboarddefinitionbyleaderboardidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarddefinitionbyleaderboardidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyleaderboardrecordbyindexApiLatest
    {
      get
      {
        int copyleaderboardrecordbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyindexApiLatest, (void*) &copyleaderboardrecordbyindexApiLatest);
        return copyleaderboardrecordbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyleaderboardrecordbyuseridApiLatest
    {
      get
      {
        int copyleaderboardrecordbyuseridApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyuseridApiLatest, (void*) &copyleaderboardrecordbyuseridApiLatest);
        return copyleaderboardrecordbyuseridApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboardrecordbyuseridApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyleaderboarduserscorebyindexApiLatest
    {
      get
      {
        int copyleaderboarduserscorebyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyindexApiLatest, (void*) &copyleaderboarduserscorebyindexApiLatest);
        return copyleaderboarduserscorebyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyleaderboarduserscorebyuseridApiLatest
    {
      get
      {
        int copyleaderboarduserscorebyuseridApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyuseridApiLatest, (void*) &copyleaderboarduserscorebyuseridApiLatest);
        return copyleaderboarduserscorebyuseridApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_CopyleaderboarduserscorebyuseridApiLatest, (void*) &value);
      }
    }

    public static unsafe int DefinitionApiLatest
    {
      get
      {
        int definitionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_DefinitionApiLatest, (void*) &definitionApiLatest);
        return definitionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_DefinitionApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetleaderboarddefinitioncountApiLatest
    {
      get
      {
        int getleaderboarddefinitioncountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarddefinitioncountApiLatest, (void*) &getleaderboarddefinitioncountApiLatest);
        return getleaderboarddefinitioncountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarddefinitioncountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetleaderboardrecordcountApiLatest
    {
      get
      {
        int getleaderboardrecordcountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboardrecordcountApiLatest, (void*) &getleaderboardrecordcountApiLatest);
        return getleaderboardrecordcountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboardrecordcountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetleaderboarduserscorecountApiLatest
    {
      get
      {
        int getleaderboarduserscorecountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarduserscorecountApiLatest, (void*) &getleaderboarduserscorecountApiLatest);
        return getleaderboarduserscorecountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_GetleaderboarduserscorecountApiLatest, (void*) &value);
      }
    }

    public static unsafe int LeaderboardrecordApiLatest
    {
      get
      {
        int leaderboardrecordApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_LeaderboardrecordApiLatest, (void*) &leaderboardrecordApiLatest);
        return leaderboardrecordApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_LeaderboardrecordApiLatest, (void*) &value);
      }
    }

    public static unsafe int LeaderboarduserscoreApiLatest
    {
      get
      {
        int leaderboarduserscoreApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_LeaderboarduserscoreApiLatest, (void*) &leaderboarduserscoreApiLatest);
        return leaderboarduserscoreApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_LeaderboarduserscoreApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryleaderboarddefinitionsApiLatest
    {
      get
      {
        int queryleaderboarddefinitionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarddefinitionsApiLatest, (void*) &queryleaderboarddefinitionsApiLatest);
        return queryleaderboarddefinitionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarddefinitionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryleaderboardranksApiLatest
    {
      get
      {
        int queryleaderboardranksApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboardranksApiLatest, (void*) &queryleaderboardranksApiLatest);
        return queryleaderboardranksApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboardranksApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryleaderboarduserscoresApiLatest
    {
      get
      {
        int queryleaderboarduserscoresApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarduserscoresApiLatest, (void*) &queryleaderboarduserscoresApiLatest);
        return queryleaderboarduserscoresApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_QueryleaderboarduserscoresApiLatest, (void*) &value);
      }
    }

    public static unsafe int TimeUndefined
    {
      get
      {
        int timeUndefined;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &timeUndefined);
        return timeUndefined;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_TimeUndefined, (void*) &value);
      }
    }

    public static unsafe int UserscoresquerystatinfoApiLatest
    {
      get
      {
        int userscoresquerystatinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(LeaderboardsInterface.NativeFieldInfoPtr_UserscoresquerystatinfoApiLatest, (void*) &userscoresquerystatinfoApiLatest);
        return userscoresquerystatinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(LeaderboardsInterface.NativeFieldInfoPtr_UserscoresquerystatinfoApiLatest, (void*) &value);
      }
    }
  }
}
