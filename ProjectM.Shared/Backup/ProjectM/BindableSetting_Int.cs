// Decompiled with JetBrains decompiler
// Type: ProjectM.BindableSetting_Int
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class BindableSetting_Int : BindableSetting<int>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763734, XrefRangeEnd = 763737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BindableSetting_Int()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindableSetting_Int>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BindableSetting_Int.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BindableSetting_Int()
    {
      Il2CppClassPointerStore<BindableSetting_Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BindableSetting_Int));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindableSetting_Int>.NativeClassPtr);
      BindableSetting_Int.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableSetting_Int>.NativeClassPtr, 100667478);
    }

    public BindableSetting_Int(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
