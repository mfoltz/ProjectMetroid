// Decompiled with JetBrains decompiler
// Type: ProjectM.Essence_StatsSettings_Asset
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
  public class Essence_StatsSettings_Asset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_statsEditorData;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Essence_StatsSettings_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1858)]
    [CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Essence_StatsSettings Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Essence_StatsSettings_Asset.NativeMethodInfoPtr_Convert_Public_Essence_StatsSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Essence_StatsSettings*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748943, XrefRangeEnd = 748951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Essence_StatsSettings_Asset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Essence_StatsSettings_Asset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Essence_StatsSettings_Asset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Essence_StatsSettings_Asset()
    {
      Il2CppClassPointerStore<Essence_StatsSettings_Asset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Essence_StatsSettings_Asset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Essence_StatsSettings_Asset>.NativeClassPtr);
      Essence_StatsSettings_Asset.NativeFieldInfoPtr_statsEditorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Essence_StatsSettings_Asset>.NativeClassPtr, nameof (statsEditorData));
      Essence_StatsSettings_Asset.NativeMethodInfoPtr_Convert_Public_Essence_StatsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Essence_StatsSettings_Asset>.NativeClassPtr, 100665943);
      Essence_StatsSettings_Asset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Essence_StatsSettings_Asset>.NativeClassPtr, 100665944);
    }

    public Essence_StatsSettings_Asset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<Essence_StatsSettings_EditorData> statsEditorData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Essence_StatsSettings_Asset.NativeFieldInfoPtr_statsEditorData));
        return pointer == IntPtr.Zero ? (List<Essence_StatsSettings_EditorData>) null : new List<Essence_StatsSettings_EditorData>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Essence_StatsSettings_Asset.NativeFieldInfoPtr_statsEditorData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
