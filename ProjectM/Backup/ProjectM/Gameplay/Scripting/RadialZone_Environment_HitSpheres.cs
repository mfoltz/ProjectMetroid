// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.RadialZone_Environment_HitSpheres
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RadialZone_Environment_HitSpheres
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    [FieldOffset(0)]
    public float3 Offset;
    [FieldOffset(12)]
    public float Radius;

    static RadialZone_Environment_HitSpheres()
    {
      Il2CppClassPointerStore<RadialZone_Environment_HitSpheres>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Gameplay.Scripting", nameof (RadialZone_Environment_HitSpheres));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RadialZone_Environment_HitSpheres>.NativeClassPtr);
      RadialZone_Environment_HitSpheres.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialZone_Environment_HitSpheres>.NativeClassPtr, nameof (Offset));
      RadialZone_Environment_HitSpheres.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RadialZone_Environment_HitSpheres>.NativeClassPtr, nameof (Radius));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RadialZone_Environment_HitSpheres>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
