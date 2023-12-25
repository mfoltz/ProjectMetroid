// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LocalizationTimeKeys
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class LocalizationTimeKeys : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Keys;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizationTimeKeys()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizationTimeKeys>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LocalizationTimeKeys.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LocalizationTimeKeys()
    {
      Il2CppClassPointerStore<LocalizationTimeKeys>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (LocalizationTimeKeys));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizationTimeKeys>.NativeClassPtr);
      LocalizationTimeKeys.NativeFieldInfoPtr_Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalizationTimeKeys>.NativeClassPtr, nameof (Keys));
      LocalizationTimeKeys.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizationTimeKeys>.NativeClassPtr, 100692284);
    }

    public LocalizationTimeKeys(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TimeLocalizationKeys Keys
    {
      get
      {
        return *(TimeLocalizationKeys*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationTimeKeys.NativeFieldInfoPtr_Keys));
      }
      [param: In] set
      {
        *(TimeLocalizationKeys*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LocalizationTimeKeys.NativeFieldInfoPtr_Keys)) = value;
      }
    }
  }
}
