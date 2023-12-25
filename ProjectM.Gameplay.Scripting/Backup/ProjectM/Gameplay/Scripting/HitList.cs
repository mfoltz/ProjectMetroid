// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.HitList
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
  public struct HitList
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeHit;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitEntity;
    [FieldOffset(0)]
    public double TimeHit;
    [FieldOffset(8)]
    public Entity HitEntity;

    static HitList()
    {
      Il2CppClassPointerStore<HitList>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (HitList));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HitList>.NativeClassPtr);
      HitList.NativeFieldInfoPtr_TimeHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitList>.NativeClassPtr, nameof (TimeHit));
      HitList.NativeFieldInfoPtr_HitEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HitList>.NativeClassPtr, nameof (HitEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HitList>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
