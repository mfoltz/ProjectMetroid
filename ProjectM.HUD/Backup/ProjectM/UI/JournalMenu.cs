// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.JournalMenu
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class JournalMenu : HUDMenu
  {
    private static readonly IntPtr NativeFieldInfoPtr_ScrollView;
    private static readonly IntPtr NativeFieldInfoPtr_JournalCategoryPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_CategoryListParent;
    private static readonly IntPtr NativeFieldInfoPtr_AchievementPrefab;
    private static readonly IntPtr NativeFieldInfoPtr_AchievementListParent;
    private static readonly IntPtr NativeFieldInfoPtr_JournalCategories;
    private static readonly IntPtr NativeFieldInfoPtr_Settings;
    private static readonly IntPtr NativeFieldInfoPtr__AchievementSubTasksInProgress;
    private static readonly IntPtr NativeFieldInfoPtr__CategoryCache;
    private static readonly IntPtr NativeFieldInfoPtr__AchievementCache;
    private static readonly IntPtr NativeFieldInfoPtr__Initialized;
    private static readonly IntPtr NativeMethodInfoPtr_get_AchievementSubTasksInProgress_Public_get_List_1_AchievementInProgressElement_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_CatecgoryCache_Public_get_UI_Cache_1_JournalCategoryEntry_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_AchievementCache_Public_get_UI_Cache_1_AchievementEntry_0;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe List<AchievementInProgressElement> AchievementSubTasksInProgress
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalMenu.NativeMethodInfoPtr_get_AchievementSubTasksInProgress_Public_get_List_1_AchievementInProgressElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (List<AchievementInProgressElement>) null : new List<AchievementInProgressElement>(pointer);
      }
    }

    public unsafe UI_Cache<JournalCategoryEntry> CatecgoryCache
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalMenu.NativeMethodInfoPtr_get_CatecgoryCache_Public_get_UI_Cache_1_JournalCategoryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (UI_Cache<JournalCategoryEntry>) null : new UI_Cache<JournalCategoryEntry>(pointer);
      }
    }

    public unsafe UI_Cache<AchievementEntry> AchievementCache
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(JournalMenu.NativeMethodInfoPtr_get_AchievementCache_Public_get_UI_Cache_1_AchievementEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        IntPtr pointer = num;
        return pointer == IntPtr.Zero ? (UI_Cache<AchievementEntry>) null : new UI_Cache<AchievementEntry>(pointer);
      }
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalMenu.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240671, XrefRangeEnd = 1240685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public new unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalMenu.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Initialize()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalMenu.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1240685, XrefRangeEnd = 1240693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JournalMenu()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JournalMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JournalMenu()
    {
      Il2CppClassPointerStore<JournalMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (JournalMenu));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr);
      JournalMenu.NativeFieldInfoPtr_ScrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (ScrollView));
      JournalMenu.NativeFieldInfoPtr_JournalCategoryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (JournalCategoryPrefab));
      JournalMenu.NativeFieldInfoPtr_CategoryListParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (CategoryListParent));
      JournalMenu.NativeFieldInfoPtr_AchievementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (AchievementPrefab));
      JournalMenu.NativeFieldInfoPtr_AchievementListParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (AchievementListParent));
      JournalMenu.NativeFieldInfoPtr_JournalCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (JournalCategories));
      JournalMenu.NativeFieldInfoPtr_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (Settings));
      JournalMenu.NativeFieldInfoPtr__AchievementSubTasksInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (_AchievementSubTasksInProgress));
      JournalMenu.NativeFieldInfoPtr__CategoryCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (_CategoryCache));
      JournalMenu.NativeFieldInfoPtr__AchievementCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (_AchievementCache));
      JournalMenu.NativeFieldInfoPtr__Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, nameof (_Initialized));
      JournalMenu.NativeMethodInfoPtr_get_AchievementSubTasksInProgress_Public_get_List_1_AchievementInProgressElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, 100666017);
      JournalMenu.NativeMethodInfoPtr_get_CatecgoryCache_Public_get_UI_Cache_1_JournalCategoryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, 100666018);
      JournalMenu.NativeMethodInfoPtr_get_AchievementCache_Public_get_UI_Cache_1_AchievementEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, 100666019);
      JournalMenu.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, 100666020);
      JournalMenu.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, 100666021);
      JournalMenu.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, 100666022);
      JournalMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JournalMenu>.NativeClassPtr, 100666023);
    }

    public JournalMenu(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ScrollRect ScrollView
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_ScrollView));
        return pointer == IntPtr.Zero ? (ScrollRect) null : new ScrollRect(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_ScrollView), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JournalCategoryEntry JournalCategoryPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_JournalCategoryPrefab));
        return pointer == IntPtr.Zero ? (JournalCategoryEntry) null : new JournalCategoryEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_JournalCategoryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform CategoryListParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_CategoryListParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_CategoryListParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AchievementEntry AchievementPrefab
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_AchievementPrefab));
        return pointer == IntPtr.Zero ? (AchievementEntry) null : new AchievementEntry(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_AchievementPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform AchievementListParent
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_AchievementListParent));
        return pointer == IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_AchievementListParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JournalCategoriesCollection JournalCategories
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_JournalCategories));
        return pointer == IntPtr.Zero ? (JournalCategoriesCollection) null : new JournalCategoriesCollection(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_JournalCategories), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe JournalSettings Settings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_Settings));
        return pointer == IntPtr.Zero ? (JournalSettings) null : new JournalSettings(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr_Settings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<AchievementInProgressElement> _AchievementSubTasksInProgress
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr__AchievementSubTasksInProgress));
        return pointer == IntPtr.Zero ? (List<AchievementInProgressElement>) null : new List<AchievementInProgressElement>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr__AchievementSubTasksInProgress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<JournalCategoryEntry> _CategoryCache
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr__CategoryCache));
        return pointer == IntPtr.Zero ? (UI_Cache<JournalCategoryEntry>) null : new UI_Cache<JournalCategoryEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr__CategoryCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe UI_Cache<AchievementEntry> _AchievementCache
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr__AchievementCache));
        return pointer == IntPtr.Zero ? (UI_Cache<AchievementEntry>) null : new UI_Cache<AchievementEntry>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr__AchievementCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr__Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JournalMenu.NativeFieldInfoPtr__Initialized)) = value;
      }
    }
  }
}
