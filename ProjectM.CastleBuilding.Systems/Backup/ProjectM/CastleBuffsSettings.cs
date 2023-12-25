// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuffsSettings
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleBuffsSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InvulnerableBuff;
    [FieldOffset(0)]
    public PrefabGUID InvulnerableBuff;

    static CastleBuffsSettings()
    {
      Il2CppClassPointerStore<CastleBuffsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM", nameof (CastleBuffsSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuffsSettings>.NativeClassPtr);
      CastleBuffsSettings.NativeFieldInfoPtr_InvulnerableBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsSettings>.NativeClassPtr, nameof (InvulnerableBuff));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuffsSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
