// Decompiled with JetBrains decompiler
// Type: ProjectM.SetDynamicCollisionHardnessModifications
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetDynamicCollisionHardnessModifications
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AgainstPlayersModId;
    private static readonly System.IntPtr NativeFieldInfoPtr_AgainstUnitsModId;
    [FieldOffset(0)]
    public ModificationId AgainstPlayersModId;
    [FieldOffset(4)]
    public ModificationId AgainstUnitsModId;

    static SetDynamicCollisionHardnessModifications()
    {
      Il2CppClassPointerStore<SetDynamicCollisionHardnessModifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SetDynamicCollisionHardnessModifications));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetDynamicCollisionHardnessModifications>.NativeClassPtr);
      SetDynamicCollisionHardnessModifications.NativeFieldInfoPtr_AgainstPlayersModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetDynamicCollisionHardnessModifications>.NativeClassPtr, nameof (AgainstPlayersModId));
      SetDynamicCollisionHardnessModifications.NativeFieldInfoPtr_AgainstUnitsModId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetDynamicCollisionHardnessModifications>.NativeClassPtr, nameof (AgainstUnitsModId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetDynamicCollisionHardnessModifications>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
