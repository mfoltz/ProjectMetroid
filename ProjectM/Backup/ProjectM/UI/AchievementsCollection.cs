// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AchievementsCollection
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class AchievementsCollection : ScriptableObject
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementEntries;
    private static readonly System.IntPtr NativeFieldInfoPtr_AchievementUIEntries;
    private static readonly System.IntPtr NativeMethodInfoPtr_GenerateUIDatas_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1160604, XrefRangeEnd = 1160626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GenerateUIDatas()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsCollection.NativeMethodInfoPtr_GenerateUIDatas_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsCollection.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AchievementsCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AchievementsCollection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AchievementsCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AchievementsCollection()
    {
      Il2CppClassPointerStore<AchievementsCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (AchievementsCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementsCollection>.NativeClassPtr);
      AchievementsCollection.NativeFieldInfoPtr_AchievementEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsCollection>.NativeClassPtr, nameof (AchievementEntries));
      AchievementsCollection.NativeFieldInfoPtr_AchievementUIEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsCollection>.NativeClassPtr, nameof (AchievementUIEntries));
      AchievementsCollection.NativeMethodInfoPtr_GenerateUIDatas_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsCollection>.NativeClassPtr, 100692254);
      AchievementsCollection.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsCollection>.NativeClassPtr, 100692255);
      AchievementsCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AchievementsCollection>.NativeClassPtr, 100692256);
    }

    public AchievementsCollection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<WeakAssetReference<GameObject>> AchievementEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsCollection.NativeFieldInfoPtr_AchievementEntries));
        return pointer == System.IntPtr.Zero ? (List<WeakAssetReference<GameObject>>) null : new List<WeakAssetReference<GameObject>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsCollection.NativeFieldInfoPtr_AchievementEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AchievementsCollection.EntryUIData> AchievementUIEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AchievementsCollection.NativeFieldInfoPtr_AchievementUIEntries));
        return pointer == System.IntPtr.Zero ? (List<AchievementsCollection.EntryUIData>) null : new List<AchievementsCollection.EntryUIData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AchievementsCollection.NativeFieldInfoPtr_AchievementUIEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    [StructLayout(LayoutKind.Explicit)]
    public struct EntryUIData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_QuestText;
      [FieldOffset(0)]
      public PrefabGUID PrefabGUID;
      [FieldOffset(4)]
      public LocalizationKey QuestText;

      static EntryUIData()
      {
        Il2CppClassPointerStore<AchievementsCollection.EntryUIData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AchievementsCollection>.NativeClassPtr, nameof (EntryUIData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AchievementsCollection.EntryUIData>.NativeClassPtr);
        AchievementsCollection.EntryUIData.NativeFieldInfoPtr_PrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsCollection.EntryUIData>.NativeClassPtr, nameof (PrefabGUID));
        AchievementsCollection.EntryUIData.NativeFieldInfoPtr_QuestText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AchievementsCollection.EntryUIData>.NativeClassPtr, nameof (QuestText));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AchievementsCollection.EntryUIData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
