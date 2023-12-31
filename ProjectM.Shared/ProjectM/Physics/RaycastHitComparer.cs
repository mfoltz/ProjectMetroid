// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.RaycastHitComparer
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
  public struct RaycastHitComparer
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768911, XrefRangeEnd = 768912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(RaycastHit x, RaycastHit y)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &x;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RaycastHitComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RaycastHitComparer()
    {
      Il2CppClassPointerStore<RaycastHitComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Physics", nameof (RaycastHitComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastHitComparer>.NativeClassPtr);
      RaycastHitComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastHitComparer>.NativeClassPtr, 100668034);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RaycastHitComparer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
