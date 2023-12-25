// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitSpawnPointBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitSpawnPointBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Point;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    [FieldOffset(0)]
    public float3 Point;
    [FieldOffset(12)]
    public float Rotation;

    static UnitSpawnPointBuffer()
    {
      Il2CppClassPointerStore<UnitSpawnPointBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UnitSpawnPointBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitSpawnPointBuffer>.NativeClassPtr);
      UnitSpawnPointBuffer.NativeFieldInfoPtr_Point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnPointBuffer>.NativeClassPtr, nameof (Point));
      UnitSpawnPointBuffer.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitSpawnPointBuffer>.NativeClassPtr, nameof (Rotation));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitSpawnPointBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
