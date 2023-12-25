// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InputContextsCollection
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class InputContextsCollection : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntryErrorGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_InputContextEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ErrorContextEntryPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr_ContextsParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_ErrorContextsParent;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddActionToCache_Public_Static_Void_InputFlag_LocalizationKey_List_1_Data_Nullable_Unboxed_1_Color_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddErrorToCach_Public_Static_Void_String_List_1_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(126)]
    [CachedScanResults(RefRangeStart = 1266754, RefRangeEnd = 1266880, XrefRangeStart = 1266741, XrefRangeEnd = 1266754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddActionToCache(
      InputFlag flag,
      LocalizationKey actionKey,
      List<InputContextEntry.Data> entries,
      Nullable_Unboxed<Color> color = default (Nullable_Unboxed<Color>),
      Nullable_Unboxed<float> value = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &flag;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &actionKey;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entries);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputContextsCollection.NativeMethodInfoPtr_AddActionToCache_Public_Static_Void_InputFlag_LocalizationKey_List_1_Data_Nullable_Unboxed_1_Color_Nullable_Unboxed_1_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 1266884, RefRangeEnd = 1266897, XrefRangeStart = 1266880, XrefRangeEnd = 1266884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AddErrorToCach(string errorText, List<ErrorContextEntry.Data> entries)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(errorText);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) entries);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputContextsCollection.NativeMethodInfoPtr_AddErrorToCach_Public_Static_Void_String_List_1_Data_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InputContextsCollection()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputContextsCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InputContextsCollection()
    {
      Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (InputContextsCollection));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr);
      InputContextsCollection.NativeFieldInfoPtr_EntryGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr, nameof (EntryGroup));
      InputContextsCollection.NativeFieldInfoPtr_EntryErrorGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr, nameof (EntryErrorGroup));
      InputContextsCollection.NativeFieldInfoPtr_InputContextEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr, nameof (InputContextEntryPrefab));
      InputContextsCollection.NativeFieldInfoPtr_ErrorContextEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr, nameof (ErrorContextEntryPrefab));
      InputContextsCollection.NativeFieldInfoPtr_ContextsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr, nameof (ContextsParent));
      InputContextsCollection.NativeFieldInfoPtr_ErrorContextsParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr, nameof (ErrorContextsParent));
      InputContextsCollection.NativeMethodInfoPtr_AddActionToCache_Public_Static_Void_InputFlag_LocalizationKey_List_1_Data_Nullable_Unboxed_1_Color_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr, 100667644);
      InputContextsCollection.NativeMethodInfoPtr_AddErrorToCach_Public_Static_Void_String_List_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr, 100667645);
      InputContextsCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputContextsCollection>.NativeClassPtr, 100667646);
    }

    public InputContextsCollection(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe StunShared.UI.EntryGroup<InputContextEntry, InputContextEntry.Data> EntryGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_EntryGroup));
        return pointer == System.IntPtr.Zero ? (StunShared.UI.EntryGroup<InputContextEntry, InputContextEntry.Data>) null : new StunShared.UI.EntryGroup<InputContextEntry, InputContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_EntryGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe StunShared.UI.EntryGroup<ErrorContextEntry, ErrorContextEntry.Data> EntryErrorGroup
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_EntryErrorGroup));
        return pointer == System.IntPtr.Zero ? (StunShared.UI.EntryGroup<ErrorContextEntry, ErrorContextEntry.Data>) null : new StunShared.UI.EntryGroup<ErrorContextEntry, ErrorContextEntry.Data>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_EntryErrorGroup), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe InputContextEntry InputContextEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_InputContextEntryPrefab));
        return pointer == System.IntPtr.Zero ? (InputContextEntry) null : new InputContextEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_InputContextEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ErrorContextEntry ErrorContextEntryPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_ErrorContextEntryPrefab));
        return pointer == System.IntPtr.Zero ? (ErrorContextEntry) null : new ErrorContextEntry(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_ErrorContextEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ContextsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_ContextsParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_ContextsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RectTransform ErrorContextsParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_ErrorContextsParent));
        return pointer == System.IntPtr.Zero ? (RectTransform) null : new RectTransform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputContextsCollection.NativeFieldInfoPtr_ErrorContextsParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
