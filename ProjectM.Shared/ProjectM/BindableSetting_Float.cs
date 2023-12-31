// Decompiled with JetBrains decompiler
// Type: ProjectM.BindableSetting_Float
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
  public class BindableSetting_Float : BindableSetting<float>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 763737, XrefRangeEnd = 763740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BindableSetting_Float()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BindableSetting_Float>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BindableSetting_Float.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BindableSetting_Float()
    {
      Il2CppClassPointerStore<BindableSetting_Float>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (BindableSetting_Float));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BindableSetting_Float>.NativeClassPtr);
      BindableSetting_Float.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BindableSetting_Float>.NativeClassPtr, 100667479);
    }

    public BindableSetting_Float(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
