// Decompiled with JetBrains decompiler
// Type: ProjectM.DropTableBuffer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DropTableBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTableGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_DropTrigger;
    private static readonly System.IntPtr NativeFieldInfoPtr_RelicType;
    [FieldOffset(0)]
    public PrefabGUID DropTableGuid;
    [FieldOffset(4)]
    public DropTriggerType DropTrigger;
    [FieldOffset(5)]
    public RelicType RelicType;

    static DropTableBuffer()
    {
      Il2CppClassPointerStore<DropTableBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropTableBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropTableBuffer>.NativeClassPtr);
      DropTableBuffer.NativeFieldInfoPtr_DropTableGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableBuffer>.NativeClassPtr, nameof (DropTableGuid));
      DropTableBuffer.NativeFieldInfoPtr_DropTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableBuffer>.NativeClassPtr, nameof (DropTrigger));
      DropTableBuffer.NativeFieldInfoPtr_RelicType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropTableBuffer>.NativeClassPtr, nameof (RelicType));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropTableBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
