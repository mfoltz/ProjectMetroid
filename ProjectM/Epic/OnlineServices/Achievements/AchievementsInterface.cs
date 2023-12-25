// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.AchievementsInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements
{
  public sealed class AchievementsInterface : Handle
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementUnlocktimeUndefined;
    private static readonly System.IntPtr NativeFieldInfoPtr_AddnotifyachievementsunlockedApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Addnotifyachievementsunlockedv2ApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Copyachievementdefinitionv2ByachievementidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Copyachievementdefinitionv2ByindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopydefinitionbyachievementidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopydefinitionbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Copydefinitionv2ByachievementidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Copydefinitionv2ByindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyplayerachievementbyachievementidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyplayerachievementbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyunlockedachievementbyachievementidApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyunlockedachievementbyindexApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefinitionApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_Definitionv2ApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetachievementdefinitioncountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetplayerachievementcountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_GetunlockedachievementcountApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerachievementApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_PlayerstatinfoApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QuerydefinitionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_QueryplayerachievementsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatthresholdApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatthresholdsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockachievementsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedachievementApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAchievementsUnlocked_Public_UInt64_byref_AddNotifyAchievementsUnlockedOptions_Object_OnAchievementsUnlockedCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddNotifyAchievementsUnlockedV2_Public_UInt64_byref_AddNotifyAchievementsUnlockedV2Options_Object_OnAchievementsUnlockedCallbackV2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAchievementDefinitionByAchievementId_Public_Result_byref_CopyAchievementDefinitionByAchievementIdOptions_byref_Nullable_1_Definition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAchievementDefinitionByIndex_Public_Result_byref_CopyAchievementDefinitionByIndexOptions_byref_Nullable_1_Definition_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAchievementDefinitionV2ByAchievementId_Public_Result_byref_CopyAchievementDefinitionV2ByAchievementIdOptions_byref_Nullable_1_DefinitionV2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyAchievementDefinitionV2ByIndex_Public_Result_byref_CopyAchievementDefinitionV2ByIndexOptions_byref_Nullable_1_DefinitionV2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPlayerAchievementByAchievementId_Public_Result_byref_CopyPlayerAchievementByAchievementIdOptions_byref_Nullable_1_PlayerAchievement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyPlayerAchievementByIndex_Public_Result_byref_CopyPlayerAchievementByIndexOptions_byref_Nullable_1_PlayerAchievement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyUnlockedAchievementByAchievementId_Public_Result_byref_CopyUnlockedAchievementByAchievementIdOptions_byref_Nullable_1_UnlockedAchievement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CopyUnlockedAchievementByIndex_Public_Result_byref_CopyUnlockedAchievementByIndexOptions_byref_Nullable_1_UnlockedAchievement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAchievementDefinitionCount_Public_UInt32_byref_GetAchievementDefinitionCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPlayerAchievementCount_Public_UInt32_byref_GetPlayerAchievementCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetUnlockedAchievementCount_Public_UInt32_byref_GetUnlockedAchievementCountOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryDefinitions_Public_Void_byref_QueryDefinitionsOptions_Object_OnQueryDefinitionsCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryPlayerAchievements_Public_Void_byref_QueryPlayerAchievementsOptions_Object_OnQueryPlayerAchievementsCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveNotifyAchievementsUnlocked_Public_Void_UInt64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UnlockAchievements_Public_Void_byref_UnlockAchievementsOptions_Object_OnUnlockAchievementsCompleteCallback_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAchievementsUnlockedCallbackInternalImplementation_Internal_Static_Void_byref_OnAchievementsUnlockedCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnAchievementsUnlockedCallbackV2InternalImplementation_Internal_Static_Void_byref_OnAchievementsUnlockedCallbackV2InfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryDefinitionsCompleteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnQueryPlayerAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryPlayerAchievementsCompleteCallbackInfoInternal_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUnlockAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnUnlockAchievementsCompleteCallbackInfoInternal_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementsInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972543, XrefRangeEnd = 972562, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyAchievementsUnlocked(
      ref AddNotifyAchievementsUnlockedOptions options,
      Il2CppSystem.Object clientData,
      OnAchievementsUnlockedCallback notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_AddNotifyAchievementsUnlocked_Public_UInt64_byref_AddNotifyAchievementsUnlockedOptions_Object_OnAchievementsUnlockedCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972562, XrefRangeEnd = 972581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ulong AddNotifyAchievementsUnlockedV2(
      ref AddNotifyAchievementsUnlockedV2Options options,
      Il2CppSystem.Object clientData,
      OnAchievementsUnlockedCallbackV2 notificationFn)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) notificationFn);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_AddNotifyAchievementsUnlockedV2_Public_UInt64_byref_AddNotifyAchievementsUnlockedV2Options_Object_OnAchievementsUnlockedCallbackV2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972581, XrefRangeEnd = 972595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyAchievementDefinitionByAchievementId(
      ref CopyAchievementDefinitionByAchievementIdOptions options,
      out Il2CppSystem.Nullable<Definition> outDefinition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionByAchievementId_Public_Result_byref_CopyAchievementDefinitionByAchievementIdOptions_byref_Nullable_1_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Definition> local = ref outDefinition;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Definition>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972595, XrefRangeEnd = 972609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyAchievementDefinitionByIndex(
      ref CopyAchievementDefinitionByIndexOptions options,
      out Il2CppSystem.Nullable<Definition> outDefinition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionByIndex_Public_Result_byref_CopyAchievementDefinitionByIndexOptions_byref_Nullable_1_Definition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<Definition> local = ref outDefinition;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<Definition>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972609, XrefRangeEnd = 972623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyAchievementDefinitionV2ByAchievementId(
      ref CopyAchievementDefinitionV2ByAchievementIdOptions options,
      out Il2CppSystem.Nullable<DefinitionV2> outDefinition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionV2ByAchievementId_Public_Result_byref_CopyAchievementDefinitionV2ByAchievementIdOptions_byref_Nullable_1_DefinitionV2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<DefinitionV2> local = ref outDefinition;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<DefinitionV2>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972623, XrefRangeEnd = 972637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyAchievementDefinitionV2ByIndex(
      ref CopyAchievementDefinitionV2ByIndexOptions options,
      out Il2CppSystem.Nullable<DefinitionV2> outDefinition)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionV2ByIndex_Public_Result_byref_CopyAchievementDefinitionV2ByIndexOptions_byref_Nullable_1_DefinitionV2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<DefinitionV2> local = ref outDefinition;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<DefinitionV2>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972637, XrefRangeEnd = 972651, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyPlayerAchievementByAchievementId(
      ref CopyPlayerAchievementByAchievementIdOptions options,
      out Il2CppSystem.Nullable<PlayerAchievement> outAchievement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyPlayerAchievementByAchievementId_Public_Result_byref_CopyPlayerAchievementByAchievementIdOptions_byref_Nullable_1_PlayerAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<PlayerAchievement> local = ref outAchievement;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<PlayerAchievement>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972651, XrefRangeEnd = 972665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyPlayerAchievementByIndex(
      ref CopyPlayerAchievementByIndexOptions options,
      out Il2CppSystem.Nullable<PlayerAchievement> outAchievement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyPlayerAchievementByIndex_Public_Result_byref_CopyPlayerAchievementByIndexOptions_byref_Nullable_1_PlayerAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<PlayerAchievement> local = ref outAchievement;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<PlayerAchievement>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972665, XrefRangeEnd = 972679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyUnlockedAchievementByAchievementId(
      ref CopyUnlockedAchievementByAchievementIdOptions options,
      out Il2CppSystem.Nullable<UnlockedAchievement> outAchievement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyUnlockedAchievementByAchievementId_Public_Result_byref_CopyUnlockedAchievementByAchievementIdOptions_byref_Nullable_1_UnlockedAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<UnlockedAchievement> local = ref outAchievement;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<UnlockedAchievement>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972679, XrefRangeEnd = 972693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Result CopyUnlockedAchievementByIndex(
      ref CopyUnlockedAchievementByIndexOptions options,
      out Il2CppSystem.Nullable<UnlockedAchievement> outAchievement)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_CopyUnlockedAchievementByIndex_Public_Result_byref_CopyUnlockedAchievementByIndexOptions_byref_Nullable_1_UnlockedAchievement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Il2CppSystem.Nullable<UnlockedAchievement> local = ref outAchievement;
      System.IntPtr pointer = zero;
      Il2CppSystem.Nullable<> nullable = pointer == System.IntPtr.Zero ? (Il2CppSystem.Nullable<>) null : new Il2CppSystem.Nullable<>(pointer);
      local = (Il2CppSystem.Nullable<UnlockedAchievement>) nullable;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972693, XrefRangeEnd = 972701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetAchievementDefinitionCount(
      ref GetAchievementDefinitionCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_GetAchievementDefinitionCount_Public_UInt32_byref_GetAchievementDefinitionCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972701, XrefRangeEnd = 972709, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetPlayerAchievementCount(ref GetPlayerAchievementCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_GetPlayerAchievementCount_Public_UInt32_byref_GetPlayerAchievementCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972709, XrefRangeEnd = 972717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe uint GetUnlockedAchievementCount(ref GetUnlockedAchievementCountOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_GetUnlockedAchievementCount_Public_UInt32_byref_GetUnlockedAchievementCountOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972717, XrefRangeEnd = 972736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryDefinitions(
      ref QueryDefinitionsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryDefinitionsCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_QueryDefinitions_Public_Void_byref_QueryDefinitionsOptions_Object_OnQueryDefinitionsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972736, XrefRangeEnd = 972755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void QueryPlayerAchievements(
      ref QueryPlayerAchievementsOptions options,
      Il2CppSystem.Object clientData,
      OnQueryPlayerAchievementsCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_QueryPlayerAchievements_Public_Void_byref_QueryPlayerAchievementsOptions_Object_OnQueryPlayerAchievementsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972755, XrefRangeEnd = 972760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveNotifyAchievementsUnlocked(ulong inId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &inId;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_RemoveNotifyAchievementsUnlocked_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972760, XrefRangeEnd = 972779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UnlockAchievements(
      ref UnlockAchievementsOptions options,
      Il2CppSystem.Object clientData,
      OnUnlockAchievementsCompleteCallback completionDelegate)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) options);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_UnlockAchievements_Public_Void_byref_UnlockAchievementsOptions_Object_OnUnlockAchievementsCompleteCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972779, XrefRangeEnd = 972786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnAchievementsUnlockedCallbackInternalImplementation(
      ref OnAchievementsUnlockedCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnAchievementsUnlockedCallbackInternalImplementation_Internal_Static_Void_byref_OnAchievementsUnlockedCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972786, XrefRangeEnd = 972793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnAchievementsUnlockedCallbackV2InternalImplementation(
      ref OnAchievementsUnlockedCallbackV2InfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnAchievementsUnlockedCallbackV2InternalImplementation_Internal_Static_Void_byref_OnAchievementsUnlockedCallbackV2InfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972793, XrefRangeEnd = 972800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryDefinitionsCompleteCallbackInternalImplementation(
      ref OnQueryDefinitionsCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnQueryDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryDefinitionsCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972800, XrefRangeEnd = 972807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnQueryPlayerAchievementsCompleteCallbackInternalImplementation(
      ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnQueryPlayerAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryPlayerAchievementsCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 972807, XrefRangeEnd = 972814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void OnUnlockAchievementsCompleteCallbackInternalImplementation(
      ref OnUnlockAchievementsCompleteCallbackInfoInternal data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsInterface.NativeMethodInfoPtr_OnUnlockAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnUnlockAchievementsCompleteCallbackInfoInternal_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AchievementsInterface()
    {
      Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Achievements", nameof (AchievementsInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr);
      AchievementsInterface.NativeFieldInfoPtr_AchievementUnlocktimeUndefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (AchievementUnlocktimeUndefined));
      AchievementsInterface.NativeFieldInfoPtr_AddnotifyachievementsunlockedApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (AddnotifyachievementsunlockedApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_Addnotifyachievementsunlockedv2ApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Addnotifyachievementsunlockedv2ApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Copyachievementdefinitionv2ByachievementidApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Copyachievementdefinitionv2ByindexApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopydefinitionbyachievementidApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopydefinitionbyindexApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Copydefinitionv2ByachievementidApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Copydefinitionv2ByindexApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopyplayerachievementbyachievementidApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopyplayerachievementbyindexApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyachievementidApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopyunlockedachievementbyachievementidApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyindexApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (CopyunlockedachievementbyindexApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_DefinitionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (DefinitionApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_Definitionv2ApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (Definitionv2ApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_GetachievementdefinitioncountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (GetachievementdefinitioncountApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_GetplayerachievementcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (GetplayerachievementcountApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_GetunlockedachievementcountApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (GetunlockedachievementcountApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_PlayerachievementApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (PlayerachievementApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_PlayerstatinfoApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (PlayerstatinfoApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_QuerydefinitionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (QuerydefinitionsApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_QueryplayerachievementsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (QueryplayerachievementsApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_StatthresholdApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (StatthresholdApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_StatthresholdsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (StatthresholdsApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_UnlockachievementsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (UnlockachievementsApiLatest));
      AchievementsInterface.NativeFieldInfoPtr_UnlockedachievementApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, nameof (UnlockedachievementApiLatest));
      AchievementsInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674832);
      AchievementsInterface.NativeMethodInfoPtr_AddNotifyAchievementsUnlocked_Public_UInt64_byref_AddNotifyAchievementsUnlockedOptions_Object_OnAchievementsUnlockedCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674834);
      AchievementsInterface.NativeMethodInfoPtr_AddNotifyAchievementsUnlockedV2_Public_UInt64_byref_AddNotifyAchievementsUnlockedV2Options_Object_OnAchievementsUnlockedCallbackV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674835);
      AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionByAchievementId_Public_Result_byref_CopyAchievementDefinitionByAchievementIdOptions_byref_Nullable_1_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674836);
      AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionByIndex_Public_Result_byref_CopyAchievementDefinitionByIndexOptions_byref_Nullable_1_Definition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674837);
      AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionV2ByAchievementId_Public_Result_byref_CopyAchievementDefinitionV2ByAchievementIdOptions_byref_Nullable_1_DefinitionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674838);
      AchievementsInterface.NativeMethodInfoPtr_CopyAchievementDefinitionV2ByIndex_Public_Result_byref_CopyAchievementDefinitionV2ByIndexOptions_byref_Nullable_1_DefinitionV2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674839);
      AchievementsInterface.NativeMethodInfoPtr_CopyPlayerAchievementByAchievementId_Public_Result_byref_CopyPlayerAchievementByAchievementIdOptions_byref_Nullable_1_PlayerAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674840);
      AchievementsInterface.NativeMethodInfoPtr_CopyPlayerAchievementByIndex_Public_Result_byref_CopyPlayerAchievementByIndexOptions_byref_Nullable_1_PlayerAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674841);
      AchievementsInterface.NativeMethodInfoPtr_CopyUnlockedAchievementByAchievementId_Public_Result_byref_CopyUnlockedAchievementByAchievementIdOptions_byref_Nullable_1_UnlockedAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674842);
      AchievementsInterface.NativeMethodInfoPtr_CopyUnlockedAchievementByIndex_Public_Result_byref_CopyUnlockedAchievementByIndexOptions_byref_Nullable_1_UnlockedAchievement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674843);
      AchievementsInterface.NativeMethodInfoPtr_GetAchievementDefinitionCount_Public_UInt32_byref_GetAchievementDefinitionCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674844);
      AchievementsInterface.NativeMethodInfoPtr_GetPlayerAchievementCount_Public_UInt32_byref_GetPlayerAchievementCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674845);
      AchievementsInterface.NativeMethodInfoPtr_GetUnlockedAchievementCount_Public_UInt32_byref_GetUnlockedAchievementCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674846);
      AchievementsInterface.NativeMethodInfoPtr_QueryDefinitions_Public_Void_byref_QueryDefinitionsOptions_Object_OnQueryDefinitionsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674847);
      AchievementsInterface.NativeMethodInfoPtr_QueryPlayerAchievements_Public_Void_byref_QueryPlayerAchievementsOptions_Object_OnQueryPlayerAchievementsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674848);
      AchievementsInterface.NativeMethodInfoPtr_RemoveNotifyAchievementsUnlocked_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674849);
      AchievementsInterface.NativeMethodInfoPtr_UnlockAchievements_Public_Void_byref_UnlockAchievementsOptions_Object_OnUnlockAchievementsCompleteCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674850);
      AchievementsInterface.NativeMethodInfoPtr_OnAchievementsUnlockedCallbackInternalImplementation_Internal_Static_Void_byref_OnAchievementsUnlockedCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674851);
      AchievementsInterface.NativeMethodInfoPtr_OnAchievementsUnlockedCallbackV2InternalImplementation_Internal_Static_Void_byref_OnAchievementsUnlockedCallbackV2InfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674852);
      AchievementsInterface.NativeMethodInfoPtr_OnQueryDefinitionsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryDefinitionsCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674853);
      AchievementsInterface.NativeMethodInfoPtr_OnQueryPlayerAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnQueryPlayerAchievementsCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674854);
      AchievementsInterface.NativeMethodInfoPtr_OnUnlockAchievementsCompleteCallbackInternalImplementation_Internal_Static_Void_byref_OnUnlockAchievementsCompleteCallbackInfoInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsInterface>.NativeClassPtr, 100674855);
    }

    public AchievementsInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int AchievementUnlocktimeUndefined
    {
      get
      {
        int unlocktimeUndefined;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_AchievementUnlocktimeUndefined, (void*) &unlocktimeUndefined);
        return unlocktimeUndefined;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_AchievementUnlocktimeUndefined, (void*) &value);
      }
    }

    public static unsafe int AddnotifyachievementsunlockedApiLatest
    {
      get
      {
        int addnotifyachievementsunlockedApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_AddnotifyachievementsunlockedApiLatest, (void*) &addnotifyachievementsunlockedApiLatest);
        return addnotifyachievementsunlockedApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_AddnotifyachievementsunlockedApiLatest, (void*) &value);
      }
    }

    public static unsafe int Addnotifyachievementsunlockedv2ApiLatest
    {
      get
      {
        int addnotifyachievementsunlockedv2ApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Addnotifyachievementsunlockedv2ApiLatest, (void*) &addnotifyachievementsunlockedv2ApiLatest);
        return addnotifyachievementsunlockedv2ApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Addnotifyachievementsunlockedv2ApiLatest, (void*) &value);
      }
    }

    public static unsafe int Copyachievementdefinitionv2ByachievementidApiLatest
    {
      get
      {
        int byachievementidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByachievementidApiLatest, (void*) &byachievementidApiLatest);
        return byachievementidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByachievementidApiLatest, (void*) &value);
      }
    }

    public static unsafe int Copyachievementdefinitionv2ByindexApiLatest
    {
      get
      {
        int byindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByindexApiLatest, (void*) &byindexApiLatest);
        return byindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Copyachievementdefinitionv2ByindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopydefinitionbyachievementidApiLatest
    {
      get
      {
        int copydefinitionbyachievementidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyachievementidApiLatest, (void*) &copydefinitionbyachievementidApiLatest);
        return copydefinitionbyachievementidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyachievementidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopydefinitionbyindexApiLatest
    {
      get
      {
        int copydefinitionbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyindexApiLatest, (void*) &copydefinitionbyindexApiLatest);
        return copydefinitionbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopydefinitionbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int Copydefinitionv2ByachievementidApiLatest
    {
      get
      {
        int byachievementidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByachievementidApiLatest, (void*) &byachievementidApiLatest);
        return byachievementidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByachievementidApiLatest, (void*) &value);
      }
    }

    public static unsafe int Copydefinitionv2ByindexApiLatest
    {
      get
      {
        int byindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByindexApiLatest, (void*) &byindexApiLatest);
        return byindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Copydefinitionv2ByindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyplayerachievementbyachievementidApiLatest
    {
      get
      {
        int copyplayerachievementbyachievementidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyachievementidApiLatest, (void*) &copyplayerachievementbyachievementidApiLatest);
        return copyplayerachievementbyachievementidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyachievementidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyplayerachievementbyindexApiLatest
    {
      get
      {
        int copyplayerachievementbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyindexApiLatest, (void*) &copyplayerachievementbyindexApiLatest);
        return copyplayerachievementbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopyplayerachievementbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyunlockedachievementbyachievementidApiLatest
    {
      get
      {
        int copyunlockedachievementbyachievementidApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyachievementidApiLatest, (void*) &copyunlockedachievementbyachievementidApiLatest);
        return copyunlockedachievementbyachievementidApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyachievementidApiLatest, (void*) &value);
      }
    }

    public static unsafe int CopyunlockedachievementbyindexApiLatest
    {
      get
      {
        int copyunlockedachievementbyindexApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyindexApiLatest, (void*) &copyunlockedachievementbyindexApiLatest);
        return copyunlockedachievementbyindexApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_CopyunlockedachievementbyindexApiLatest, (void*) &value);
      }
    }

    public static unsafe int DefinitionApiLatest
    {
      get
      {
        int definitionApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_DefinitionApiLatest, (void*) &definitionApiLatest);
        return definitionApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_DefinitionApiLatest, (void*) &value);
      }
    }

    public static unsafe int Definitionv2ApiLatest
    {
      get
      {
        int definitionv2ApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_Definitionv2ApiLatest, (void*) &definitionv2ApiLatest);
        return definitionv2ApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_Definitionv2ApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetachievementdefinitioncountApiLatest
    {
      get
      {
        int getachievementdefinitioncountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_GetachievementdefinitioncountApiLatest, (void*) &getachievementdefinitioncountApiLatest);
        return getachievementdefinitioncountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_GetachievementdefinitioncountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetplayerachievementcountApiLatest
    {
      get
      {
        int getplayerachievementcountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_GetplayerachievementcountApiLatest, (void*) &getplayerachievementcountApiLatest);
        return getplayerachievementcountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_GetplayerachievementcountApiLatest, (void*) &value);
      }
    }

    public static unsafe int GetunlockedachievementcountApiLatest
    {
      get
      {
        int getunlockedachievementcountApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_GetunlockedachievementcountApiLatest, (void*) &getunlockedachievementcountApiLatest);
        return getunlockedachievementcountApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_GetunlockedachievementcountApiLatest, (void*) &value);
      }
    }

    public static unsafe int PlayerachievementApiLatest
    {
      get
      {
        int playerachievementApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_PlayerachievementApiLatest, (void*) &playerachievementApiLatest);
        return playerachievementApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_PlayerachievementApiLatest, (void*) &value);
      }
    }

    public static unsafe int PlayerstatinfoApiLatest
    {
      get
      {
        int playerstatinfoApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_PlayerstatinfoApiLatest, (void*) &playerstatinfoApiLatest);
        return playerstatinfoApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_PlayerstatinfoApiLatest, (void*) &value);
      }
    }

    public static unsafe int QuerydefinitionsApiLatest
    {
      get
      {
        int querydefinitionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_QuerydefinitionsApiLatest, (void*) &querydefinitionsApiLatest);
        return querydefinitionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_QuerydefinitionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int QueryplayerachievementsApiLatest
    {
      get
      {
        int queryplayerachievementsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_QueryplayerachievementsApiLatest, (void*) &queryplayerachievementsApiLatest);
        return queryplayerachievementsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_QueryplayerachievementsApiLatest, (void*) &value);
      }
    }

    public static unsafe int StatthresholdApiLatest
    {
      get
      {
        int statthresholdApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_StatthresholdApiLatest, (void*) &statthresholdApiLatest);
        return statthresholdApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_StatthresholdApiLatest, (void*) &value);
      }
    }

    public static unsafe int StatthresholdsApiLatest
    {
      get
      {
        int statthresholdsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_StatthresholdsApiLatest, (void*) &statthresholdsApiLatest);
        return statthresholdsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_StatthresholdsApiLatest, (void*) &value);
      }
    }

    public static unsafe int UnlockachievementsApiLatest
    {
      get
      {
        int unlockachievementsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_UnlockachievementsApiLatest, (void*) &unlockachievementsApiLatest);
        return unlockachievementsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_UnlockachievementsApiLatest, (void*) &value);
      }
    }

    public static unsafe int UnlockedachievementApiLatest
    {
      get
      {
        int unlockedachievementApiLatest;
        IL2CPP.il2cpp_field_static_get_value(AchievementsInterface.NativeFieldInfoPtr_UnlockedachievementApiLatest, (void*) &unlockedachievementApiLatest);
        return unlockedachievementApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AchievementsInterface.NativeFieldInfoPtr_UnlockedachievementApiLatest, (void*) &value);
      }
    }
  }
}
