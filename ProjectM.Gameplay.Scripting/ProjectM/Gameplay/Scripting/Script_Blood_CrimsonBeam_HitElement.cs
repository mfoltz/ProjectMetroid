// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Blood_CrimsonBeam_HitElement
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Blood_CrimsonBeam_HitElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeHit;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public float TimeHit;

    static Script_Blood_CrimsonBeam_HitElement()
    {
      Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Blood_CrimsonBeam_HitElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitElement>.NativeClassPtr);
      Script_Blood_CrimsonBeam_HitElement.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitElement>.NativeClassPtr, nameof (Entity));
      Script_Blood_CrimsonBeam_HitElement.NativeFieldInfoPtr_TimeHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitElement>.NativeClassPtr, nameof (TimeHit));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Blood_CrimsonBeam_HitElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
