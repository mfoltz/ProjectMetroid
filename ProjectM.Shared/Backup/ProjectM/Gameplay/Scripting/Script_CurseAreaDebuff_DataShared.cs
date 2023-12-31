// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_CurseAreaDebuff_DataShared
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_CurseAreaDebuff_DataShared
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsInArea;
    private static readonly System.IntPtr NativeFieldInfoPtr_StackSize;
    [FieldOffset(0)]
    public bool IsInArea;
    [FieldOffset(1)]
    public byte StackSize;

    static Script_CurseAreaDebuff_DataShared()
    {
      Il2CppClassPointerStore<Script_CurseAreaDebuff_DataShared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Gameplay.Scripting", nameof (Script_CurseAreaDebuff_DataShared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_CurseAreaDebuff_DataShared>.NativeClassPtr);
      Script_CurseAreaDebuff_DataShared.NativeFieldInfoPtr_IsInArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CurseAreaDebuff_DataShared>.NativeClassPtr, nameof (IsInArea));
      Script_CurseAreaDebuff_DataShared.NativeFieldInfoPtr_StackSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_CurseAreaDebuff_DataShared>.NativeClassPtr, nameof (StackSize));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_CurseAreaDebuff_DataShared>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
