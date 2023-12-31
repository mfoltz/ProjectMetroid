// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SharedConditionalAsset
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
namespace ProjectM.Shared
{
  public class SharedConditionalAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Group;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SharedConditionalAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SharedConditionalAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SharedConditionalAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SharedConditionalAsset()
    {
      Il2CppClassPointerStore<SharedConditionalAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SharedConditionalAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SharedConditionalAsset>.NativeClassPtr);
      SharedConditionalAsset.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SharedConditionalAsset>.NativeClassPtr, nameof (Group));
      SharedConditionalAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SharedConditionalAsset>.NativeClassPtr, 100670738);
    }

    public SharedConditionalAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ConditionalGroupAuthoring Group
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SharedConditionalAsset.NativeFieldInfoPtr_Group));
        return pointer == IntPtr.Zero ? (ConditionalGroupAuthoring) null : new ConditionalGroupAuthoring(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SharedConditionalAsset.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
