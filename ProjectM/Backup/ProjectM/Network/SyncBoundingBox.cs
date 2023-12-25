// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SyncBoundingBox
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SyncBoundingBox
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxX;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinX;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxZ;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinZ;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectPositionToBox_Public_float2_float2_0;
    [FieldOffset(0)]
    public float MaxX;
    [FieldOffset(4)]
    public float MinX;
    [FieldOffset(8)]
    public float MaxZ;
    [FieldOffset(12)]
    public float MinZ;

    [CallerCount(0)]
    public unsafe float2 ProjectPositionToBox(float2 position)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &position;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SyncBoundingBox.NativeMethodInfoPtr_ProjectPositionToBox_Public_float2_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float2*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SyncBoundingBox()
    {
      Il2CppClassPointerStore<SyncBoundingBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (SyncBoundingBox));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SyncBoundingBox>.NativeClassPtr);
      SyncBoundingBox.NativeFieldInfoPtr_MaxX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncBoundingBox>.NativeClassPtr, nameof (MaxX));
      SyncBoundingBox.NativeFieldInfoPtr_MinX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncBoundingBox>.NativeClassPtr, nameof (MinX));
      SyncBoundingBox.NativeFieldInfoPtr_MaxZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncBoundingBox>.NativeClassPtr, nameof (MaxZ));
      SyncBoundingBox.NativeFieldInfoPtr_MinZ = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SyncBoundingBox>.NativeClassPtr, nameof (MinZ));
      SyncBoundingBox.NativeMethodInfoPtr_ProjectPositionToBox_Public_float2_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SyncBoundingBox>.NativeClassPtr, 100691201);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SyncBoundingBox>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
