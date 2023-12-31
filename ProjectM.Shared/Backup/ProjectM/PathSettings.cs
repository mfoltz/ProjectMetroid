// Decompiled with JetBrains decompiler
// Type: ProjectM.PathSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PathSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Looping;
    private static readonly System.IntPtr NativeFieldInfoPtr_PathColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_FirstNode;
    [FieldOffset(0)]
    public bool Looping;
    [FieldOffset(4)]
    public Color PathColor;
    [FieldOffset(20)]
    public Entity FirstNode;

    static PathSettings()
    {
      Il2CppClassPointerStore<PathSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (PathSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSettings>.NativeClassPtr);
      PathSettings.NativeFieldInfoPtr_Looping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, nameof (Looping));
      PathSettings.NativeFieldInfoPtr_PathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, nameof (PathColor));
      PathSettings.NativeFieldInfoPtr_FirstNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, nameof (FirstNode));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PathSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
