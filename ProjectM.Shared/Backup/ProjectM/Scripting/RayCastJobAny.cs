// Decompiled with JetBrains decompiler
// Type: ProjectM.Scripting.RayCastJobAny
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;
using Unity.Physics;

#nullable disable
namespace ProjectM.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RayCastJobAny
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr_From;
    private static readonly System.IntPtr NativeFieldInfoPtr_To;
    private static readonly System.IntPtr NativeFieldInfoPtr_CollisionFilter;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitAnything;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public CollisionWorld CollisionWorld;
    [FieldOffset(344)]
    public float3 From;
    [FieldOffset(356)]
    public float3 To;
    [FieldOffset(368)]
    public CollisionFilter CollisionFilter;
    [FieldOffset(384)]
    public NativeReference<bool> HitAnything;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 774160, XrefRangeEnd = 774166, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RayCastJobAny.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RayCastJobAny()
    {
      Il2CppClassPointerStore<RayCastJobAny>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Scripting", nameof (RayCastJobAny));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RayCastJobAny>.NativeClassPtr);
      RayCastJobAny.NativeFieldInfoPtr_CollisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJobAny>.NativeClassPtr, nameof (CollisionWorld));
      RayCastJobAny.NativeFieldInfoPtr_From = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJobAny>.NativeClassPtr, nameof (From));
      RayCastJobAny.NativeFieldInfoPtr_To = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJobAny>.NativeClassPtr, nameof (To));
      RayCastJobAny.NativeFieldInfoPtr_CollisionFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJobAny>.NativeClassPtr, nameof (CollisionFilter));
      RayCastJobAny.NativeFieldInfoPtr_HitAnything = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RayCastJobAny>.NativeClassPtr, nameof (HitAnything));
      RayCastJobAny.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RayCastJobAny>.NativeClassPtr, 100668595);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RayCastJobAny>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
