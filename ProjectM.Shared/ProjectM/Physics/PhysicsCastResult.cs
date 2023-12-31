// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.PhysicsCastResult
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Physics
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PhysicsCastResult
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Fraction;
    private static readonly System.IntPtr NativeFieldInfoPtr_SurfaceNormal;
    private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PhysicsCastResult_0;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public float3 Position;
    [FieldOffset(20)]
    public float Fraction;
    [FieldOffset(24)]
    public float3 SurfaceNormal;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 768910, XrefRangeEnd = 768911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int CompareTo(PhysicsCastResult other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PhysicsCastResult.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PhysicsCastResult_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PhysicsCastResult()
    {
      Il2CppClassPointerStore<PhysicsCastResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Physics", nameof (PhysicsCastResult));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsCastResult>.NativeClassPtr);
      PhysicsCastResult.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCastResult>.NativeClassPtr, nameof (Entity));
      PhysicsCastResult.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCastResult>.NativeClassPtr, nameof (Position));
      PhysicsCastResult.NativeFieldInfoPtr_Fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCastResult>.NativeClassPtr, nameof (Fraction));
      PhysicsCastResult.NativeFieldInfoPtr_SurfaceNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsCastResult>.NativeClassPtr, nameof (SurfaceNormal));
      PhysicsCastResult.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PhysicsCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsCastResult>.NativeClassPtr, 100668033);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PhysicsCastResult>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
