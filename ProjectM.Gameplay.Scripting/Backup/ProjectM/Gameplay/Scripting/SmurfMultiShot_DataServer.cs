// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.SmurfMultiShot_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SmurfMultiShot_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NewProjectile;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuidForPlacementRules;
    private static readonly System.IntPtr NativeFieldInfoPtr_Count;
    private static readonly System.IntPtr NativeFieldInfoPtr_Angle;
    [FieldOffset(0)]
    public PrefabGUID NewProjectile;
    [FieldOffset(4)]
    public PrefabGUID PrefabGuidForPlacementRules;
    [FieldOffset(8)]
    public int Count;
    [FieldOffset(12)]
    public float Angle;

    static SmurfMultiShot_DataServer()
    {
      Il2CppClassPointerStore<SmurfMultiShot_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (SmurfMultiShot_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmurfMultiShot_DataServer>.NativeClassPtr);
      SmurfMultiShot_DataServer.NativeFieldInfoPtr_NewProjectile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfMultiShot_DataServer>.NativeClassPtr, nameof (NewProjectile));
      SmurfMultiShot_DataServer.NativeFieldInfoPtr_PrefabGuidForPlacementRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfMultiShot_DataServer>.NativeClassPtr, nameof (PrefabGuidForPlacementRules));
      SmurfMultiShot_DataServer.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfMultiShot_DataServer>.NativeClassPtr, nameof (Count));
      SmurfMultiShot_DataServer.NativeFieldInfoPtr_Angle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmurfMultiShot_DataServer>.NativeClassPtr, nameof (Angle));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SmurfMultiShot_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
