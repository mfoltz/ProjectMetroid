// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantColor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class ServantColor : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NormalUnitColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantUnitColor;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantColor()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantColor>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantColor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantColor()
    {
      Il2CppClassPointerStore<ServantColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServantColor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantColor>.NativeClassPtr);
      ServantColor.NativeFieldInfoPtr_NormalUnitColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantColor>.NativeClassPtr, nameof (NormalUnitColor));
      ServantColor.NativeFieldInfoPtr_ServantUnitColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantColor>.NativeClassPtr, nameof (ServantUnitColor));
      ServantColor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantColor>.NativeClassPtr, 100665760);
    }

    public ServantColor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color NormalUnitColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantColor.NativeFieldInfoPtr_NormalUnitColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantColor.NativeFieldInfoPtr_NormalUnitColor)) = value;
      }
    }

    public unsafe Color ServantUnitColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantColor.NativeFieldInfoPtr_ServantUnitColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantColor.NativeFieldInfoPtr_ServantUnitColor)) = value;
      }
    }
  }
}
