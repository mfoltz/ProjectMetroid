// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.DistanceHitDistanceComparer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Physics;

#nullable disable
namespace ProjectM.Physics
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DistanceHitDistanceComparer
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_DistanceHit_DistanceHit_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768912, XrefRangeEnd = 768915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(DistanceHit a, DistanceHit b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DistanceHitDistanceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_DistanceHit_DistanceHit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DistanceHitDistanceComparer()
    {
      Il2CppClassPointerStore<DistanceHitDistanceComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Physics", nameof (DistanceHitDistanceComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DistanceHitDistanceComparer>.NativeClassPtr);
      DistanceHitDistanceComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_DistanceHit_DistanceHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DistanceHitDistanceComparer>.NativeClassPtr, 100668035);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DistanceHitDistanceComparer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
