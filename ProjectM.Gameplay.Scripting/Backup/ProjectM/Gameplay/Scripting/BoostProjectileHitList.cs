// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.BoostProjectileHitList
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
  public struct BoostProjectileHitList
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeHit;
    private static readonly System.IntPtr NativeFieldInfoPtr_HitEntity;
    [FieldOffset(0)]
    public double TimeHit;
    [FieldOffset(8)]
    public Entity HitEntity;

    static BoostProjectileHitList()
    {
      Il2CppClassPointerStore<BoostProjectileHitList>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (BoostProjectileHitList));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoostProjectileHitList>.NativeClassPtr);
      BoostProjectileHitList.NativeFieldInfoPtr_TimeHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostProjectileHitList>.NativeClassPtr, nameof (TimeHit));
      BoostProjectileHitList.NativeFieldInfoPtr_HitEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoostProjectileHitList>.NativeClassPtr, nameof (HitEntity));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoostProjectileHitList>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
