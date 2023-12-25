// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.AttributeKeysSetting
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
  public class AttributeKeysSetting : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Keys;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AttributeKeysSetting()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeKeysSetting>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeKeysSetting.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AttributeKeysSetting()
    {
      Il2CppClassPointerStore<AttributeKeysSetting>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (AttributeKeysSetting));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeKeysSetting>.NativeClassPtr);
      AttributeKeysSetting.NativeFieldInfoPtr_Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeKeysSetting>.NativeClassPtr, nameof (Keys));
      AttributeKeysSetting.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeKeysSetting>.NativeClassPtr, 100692277);
    }

    public AttributeKeysSetting(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe AttributeKeys Keys
    {
      get
      {
        return *(AttributeKeys*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeKeysSetting.NativeFieldInfoPtr_Keys));
      }
      [param: In] set
      {
        *(AttributeKeys*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttributeKeysSetting.NativeFieldInfoPtr_Keys)) = value;
      }
    }
  }
}
