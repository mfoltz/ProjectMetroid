// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizedStatusMessagesAsset
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class LocalizedStatusMessagesAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_LocalizedStatusChanges;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedStatusMessagesAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedStatusMessagesAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalizedStatusMessagesAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocalizedStatusMessagesAsset()
    {
      Il2CppClassPointerStore<LocalizedStatusMessagesAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (LocalizedStatusMessagesAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedStatusMessagesAsset>.NativeClassPtr);
      LocalizedStatusMessagesAsset.NativeFieldInfoPtr_LocalizedStatusChanges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizedStatusMessagesAsset>.NativeClassPtr, nameof (LocalizedStatusChanges));
      LocalizedStatusMessagesAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedStatusMessagesAsset>.NativeClassPtr, 100668810);
    }

    public LocalizedStatusMessagesAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<LocalizedStatusChange> LocalizedStatusChanges
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStatusMessagesAsset.NativeFieldInfoPtr_LocalizedStatusChanges));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<LocalizedStatusChange>) null : new Il2CppStructArray<LocalizedStatusChange>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LocalizedStatusMessagesAsset.NativeFieldInfoPtr_LocalizedStatusChanges), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
