// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnLocationData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpawnLocationData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_X;
    private static readonly System.IntPtr NativeFieldInfoPtr_Points;
    [FieldOffset(0)]
    public float X;
    [FieldOffset(4)]
    public int Points;

    static SpawnLocationData()
    {
      Il2CppClassPointerStore<SpawnLocationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnLocationData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnLocationData>.NativeClassPtr);
      SpawnLocationData.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnLocationData>.NativeClassPtr, nameof (X));
      SpawnLocationData.NativeFieldInfoPtr_Points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnLocationData>.NativeClassPtr, nameof (Points));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnLocationData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
