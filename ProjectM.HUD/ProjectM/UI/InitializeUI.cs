// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InitializeUI
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using Unity.Scenes;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class InitializeUI : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AlreadyShownLoading;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubScene_UI;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubScene_UIAssets;
    private static readonly System.IntPtr NativeFieldInfoPtr_UIConversionPrefab;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_LocalizationSettings_Public_Static_get_LocalizationSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public static unsafe LocalizationSettings LocalizationSettings
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1266684, RefRangeEnd = 1266685, XrefRangeStart = 1266592, XrefRangeEnd = 1266684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(InitializeUI.NativeMethodInfoPtr_get_LocalizationSettings_Public_Static_get_LocalizationSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new LocalizationSettings(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266685, XrefRangeEnd = 1266741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InitializeUI()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InitializeUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InitializeUI()
    {
      Il2CppClassPointerStore<InitializeUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InitializeUI));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr);
      InitializeUI.NativeFieldInfoPtr_AlreadyShownLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr, nameof (AlreadyShownLoading));
      InitializeUI.NativeFieldInfoPtr_SubScene_UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr, nameof (SubScene_UI));
      InitializeUI.NativeFieldInfoPtr_SubScene_UIAssets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr, nameof (SubScene_UIAssets));
      InitializeUI.NativeFieldInfoPtr_UIConversionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr, nameof (UIConversionPrefab));
      InitializeUI.NativeMethodInfoPtr_get_LocalizationSettings_Public_Static_get_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr, 100667634);
      InitializeUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr, 100667635);
      InitializeUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr, 100667636);
    }

    public InitializeUI(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool AlreadyShownLoading
    {
      get
      {
        bool alreadyShownLoading;
        IL2CPP.il2cpp_field_static_get_value(InitializeUI.NativeFieldInfoPtr_AlreadyShownLoading, (void*) &alreadyShownLoading);
        return alreadyShownLoading;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InitializeUI.NativeFieldInfoPtr_AlreadyShownLoading, (void*) &value);
      }
    }

    public unsafe SubScene SubScene_UI
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeUI.NativeFieldInfoPtr_SubScene_UI));
        return pointer == System.IntPtr.Zero ? (SubScene) null : new SubScene(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeUI.NativeFieldInfoPtr_SubScene_UI), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SubScene SubScene_UIAssets
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeUI.NativeFieldInfoPtr_SubScene_UIAssets));
        return pointer == System.IntPtr.Zero ? (SubScene) null : new SubScene(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeUI.NativeFieldInfoPtr_SubScene_UIAssets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<GameObject> UIConversionPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeUI.NativeFieldInfoPtr_UIConversionPrefab));
        return pointer == System.IntPtr.Zero ? (WeakAssetReference<GameObject>) null : new WeakAssetReference<GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeUI.NativeFieldInfoPtr_UIConversionPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.UI.InitializeUI/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_localizationCodes;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_LocalizationSettings_b__3_Internal_List_1_LocalizationCode_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeUI.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeUI.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(8)]
      [CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe List<LocalizationCode> _get_LocalizationSettings_b__3()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InitializeUI.__c__DisplayClass5_0.NativeMethodInfoPtr__get_LocalizationSettings_b__3_Internal_List_1_LocalizationCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<LocalizationCode>) null : new List<LocalizationCode>(pointer);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<InitializeUI.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeUI.__c__DisplayClass5_0>.NativeClassPtr);
        InitializeUI.__c__DisplayClass5_0.NativeFieldInfoPtr_localizationCodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeUI.__c__DisplayClass5_0>.NativeClassPtr, nameof (localizationCodes));
        InitializeUI.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeUI.__c__DisplayClass5_0>.NativeClassPtr, 100667637);
        InitializeUI.__c__DisplayClass5_0.NativeMethodInfoPtr__get_LocalizationSettings_b__3_Internal_List_1_LocalizationCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeUI.__c__DisplayClass5_0>.NativeClassPtr, 100667638);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<LocalizationCode> localizationCodes
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InitializeUI.__c__DisplayClass5_0.NativeFieldInfoPtr_localizationCodes));
          return pointer == System.IntPtr.Zero ? (List<LocalizationCode>) null : new List<LocalizationCode>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InitializeUI.__c__DisplayClass5_0.NativeFieldInfoPtr_localizationCodes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UI.InitializeUI/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_2;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_LocalizationSettings_b__5_0_Internal_Void_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_LocalizationSettings_b__5_1_Internal_Void_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_LocalizationSettings_b__5_2_Internal_Void_String_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266580, XrefRangeEnd = 1266584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _get_LocalizationSettings_b__5_0(string error)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(error);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeUI.__c.NativeMethodInfoPtr__get_LocalizationSettings_b__5_0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266584, XrefRangeEnd = 1266588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _get_LocalizationSettings_b__5_1(string error)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(error);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeUI.__c.NativeMethodInfoPtr__get_LocalizationSettings_b__5_1_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266588, XrefRangeEnd = 1266592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _get_LocalizationSettings_b__5_2(string error)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(error);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InitializeUI.__c.NativeMethodInfoPtr__get_LocalizationSettings_b__5_2_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializeUI>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr);
        InitializeUI.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr, "<>9");
        InitializeUI.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr, "<>9__5_0");
        InitializeUI.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr, "<>9__5_1");
        InitializeUI.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr, "<>9__5_2");
        InitializeUI.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr, 100667640);
        InitializeUI.__c.NativeMethodInfoPtr__get_LocalizationSettings_b__5_0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr, 100667641);
        InitializeUI.__c.NativeMethodInfoPtr__get_LocalizationSettings_b__5_1_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr, 100667642);
        InitializeUI.__c.NativeMethodInfoPtr__get_LocalizationSettings_b__5_2_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializeUI.__c>.NativeClassPtr, 100667643);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe InitializeUI.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InitializeUI.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InitializeUI.__c) null : new InitializeUI.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InitializeUI.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<string> __9__5_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InitializeUI.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<string>) null : new Il2CppSystem.Action<string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InitializeUI.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<string> __9__5_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InitializeUI.__c.NativeFieldInfoPtr___9__5_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<string>) null : new Il2CppSystem.Action<string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InitializeUI.__c.NativeFieldInfoPtr___9__5_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<string> __9__5_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InitializeUI.__c.NativeFieldInfoPtr___9__5_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<string>) null : new Il2CppSystem.Action<string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InitializeUI.__c.NativeFieldInfoPtr___9__5_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
