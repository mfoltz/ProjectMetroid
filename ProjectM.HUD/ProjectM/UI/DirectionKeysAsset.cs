// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DirectionKeysAsset
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Stunlock.Localization;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class DirectionKeysAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Keys;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DirectionKeysAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DirectionKeysAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DirectionKeysAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DirectionKeysAsset()
    {
      Il2CppClassPointerStore<DirectionKeysAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DirectionKeysAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DirectionKeysAsset>.NativeClassPtr);
      DirectionKeysAsset.NativeFieldInfoPtr_Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DirectionKeysAsset>.NativeClassPtr, nameof (Keys));
      DirectionKeysAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DirectionKeysAsset>.NativeClassPtr, 100667455);
    }

    public DirectionKeysAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppStructArray<LocalizationKey> Keys
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DirectionKeysAsset.NativeFieldInfoPtr_Keys));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<LocalizationKey>) null : new Il2CppStructArray<LocalizationKey>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DirectionKeysAsset.NativeFieldInfoPtr_Keys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
