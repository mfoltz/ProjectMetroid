// Decompiled with JetBrains decompiler
// Type: ProjectM.HUDMenuTypeArray
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using ProjectM.UI;
using System;

#nullable disable
namespace ProjectM
{
  public class HUDMenuTypeArray : ReorderableArray<HUDMenuType>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1210526, XrefRangeEnd = 1210529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HUDMenuTypeArray()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HUDMenuTypeArray>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HUDMenuTypeArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HUDMenuTypeArray()
    {
      Il2CppClassPointerStore<HUDMenuTypeArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (HUDMenuTypeArray));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HUDMenuTypeArray>.NativeClassPtr);
      HUDMenuTypeArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HUDMenuTypeArray>.NativeClassPtr, 100663677);
    }

    public HUDMenuTypeArray(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
