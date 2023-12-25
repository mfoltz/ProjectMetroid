// Decompiled with JetBrains decompiler
// Type: ProjectM.StatChangeUtility
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class StatChangeUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DebuggingActive;
    private static readonly System.IntPtr NativeMethodInfoPtr_KillEntity_Public_Static_Void_EntityManager_Entity_Entity_Double_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_KillOrDestroyEntity_Public_Static_Void_EntityManager_Entity_Entity_Entity_Double_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_KillEntity_Public_Static_Void_EntityManager_Entity_Entity_byref_Health_byref_HealthConstants_Double_Entity_RagdollSourceSetting_Single_Boolean_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1072986, RefRangeEnd = 1072988, XrefRangeStart = 1072976, XrefRangeEnd = 1072986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void KillEntity(
      EntityManager entityManager,
      Entity entity,
      Entity killer,
      double currentTime,
      bool killImmortals = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &killer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &currentTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &killImmortals;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeUtility.NativeMethodInfoPtr_KillEntity_Public_Static_Void_EntityManager_Entity_Entity_Double_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1073007, RefRangeEnd = 1073010, XrefRangeStart = 1072988, XrefRangeEnd = 1073007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void KillOrDestroyEntity(
      EntityManager entityManager,
      Entity entity,
      Entity killer,
      Entity killerSource,
      double currentTime,
      bool killImmortals = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &killer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &killerSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &currentTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &killImmortals;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeUtility.NativeMethodInfoPtr_KillOrDestroyEntity_Public_Static_Void_EntityManager_Entity_Entity_Entity_Double_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1073070, RefRangeEnd = 1073072, XrefRangeStart = 1073010, XrefRangeEnd = 1073070, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void KillEntity(
      EntityManager entityManager,
      Entity entity,
      Entity killer,
      ref Health health,
      [In] ref HealthConstants healthConstants,
      double currentTime,
      Entity spellSource = default (Entity),
      RagdollSourceSetting ragdollSettings = default (RagdollSourceSetting),
      float forceModifier = 0.0f,
      bool killImmortals = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &killer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref health;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref healthConstants;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &currentTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &spellSource;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &ragdollSettings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) &forceModifier;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) &killImmortals;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StatChangeUtility.NativeMethodInfoPtr_KillEntity_Public_Static_Void_EntityManager_Entity_Entity_byref_Health_byref_HealthConstants_Double_Entity_RagdollSourceSetting_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StatChangeUtility()
    {
      Il2CppClassPointerStore<StatChangeUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (StatChangeUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatChangeUtility>.NativeClassPtr);
      StatChangeUtility.NativeFieldInfoPtr_DebuggingActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatChangeUtility>.NativeClassPtr, nameof (DebuggingActive));
      StatChangeUtility.NativeMethodInfoPtr_KillEntity_Public_Static_Void_EntityManager_Entity_Entity_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeUtility>.NativeClassPtr, 100684531);
      StatChangeUtility.NativeMethodInfoPtr_KillOrDestroyEntity_Public_Static_Void_EntityManager_Entity_Entity_Entity_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeUtility>.NativeClassPtr, 100684532);
      StatChangeUtility.NativeMethodInfoPtr_KillEntity_Public_Static_Void_EntityManager_Entity_Entity_byref_Health_byref_HealthConstants_Double_Entity_RagdollSourceSetting_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatChangeUtility>.NativeClassPtr, 100684533);
    }

    public StatChangeUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool DebuggingActive
    {
      get
      {
        bool debuggingActive;
        IL2CPP.il2cpp_field_static_get_value(StatChangeUtility.NativeFieldInfoPtr_DebuggingActive, (void*) &debuggingActive);
        return debuggingActive;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StatChangeUtility.NativeFieldInfoPtr_DebuggingActive, (void*) &value);
      }
    }
  }
}
