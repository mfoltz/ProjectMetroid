// Decompiled with JetBrains decompiler
// Type: ProjectM.Item_DurabilitySettings_Asset
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class Item_DurabilitySettings_Asset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_statsEditorData;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Item_DurabilitySettings_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Item_DurabilitySettings Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Item_DurabilitySettings_Asset.NativeMethodInfoPtr_Convert_Public_Item_DurabilitySettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Item_DurabilitySettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749108, XrefRangeEnd = 749116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Item_DurabilitySettings_Asset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Item_DurabilitySettings_Asset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Item_DurabilitySettings_Asset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Item_DurabilitySettings_Asset()
    {
      Il2CppClassPointerStore<Item_DurabilitySettings_Asset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Item_DurabilitySettings_Asset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Item_DurabilitySettings_Asset>.NativeClassPtr);
      Item_DurabilitySettings_Asset.NativeFieldInfoPtr_statsEditorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Item_DurabilitySettings_Asset>.NativeClassPtr, nameof (statsEditorData));
      Item_DurabilitySettings_Asset.NativeMethodInfoPtr_Convert_Public_Item_DurabilitySettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item_DurabilitySettings_Asset>.NativeClassPtr, 100665960);
      Item_DurabilitySettings_Asset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Item_DurabilitySettings_Asset>.NativeClassPtr, 100665961);
    }

    public Item_DurabilitySettings_Asset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<Item_DurabilitySettings_EditorData> statsEditorData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Item_DurabilitySettings_Asset.NativeFieldInfoPtr_statsEditorData));
        return pointer == IntPtr.Zero ? (List<Item_DurabilitySettings_EditorData>) null : new List<Item_DurabilitySettings_EditorData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Item_DurabilitySettings_Asset.NativeFieldInfoPtr_statsEditorData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
