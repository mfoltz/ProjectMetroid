// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleTeleporterElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleTeleporterElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleTeleporterMaxGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Group;
    [FieldOffset(0)]
    public NetworkedEntity Entity;
    [FieldOffset(12)]
    public byte Group;

    static CastleTeleporterElement()
    {
      Il2CppClassPointerStore<CastleTeleporterElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleTeleporterElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleTeleporterElement>.NativeClassPtr);
      CastleTeleporterElement.NativeFieldInfoPtr_CastleTeleporterMaxGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTeleporterElement>.NativeClassPtr, nameof (CastleTeleporterMaxGroup));
      CastleTeleporterElement.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTeleporterElement>.NativeClassPtr, nameof (Entity));
      CastleTeleporterElement.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleTeleporterElement>.NativeClassPtr, nameof (Group));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleTeleporterElement>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe byte CastleTeleporterMaxGroup
    {
      get
      {
        byte teleporterMaxGroup;
        IL2CPP.il2cpp_field_static_get_value(CastleTeleporterElement.NativeFieldInfoPtr_CastleTeleporterMaxGroup, (void*) &teleporterMaxGroup);
        return teleporterMaxGroup;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(CastleTeleporterElement.NativeFieldInfoPtr_CastleTeleporterMaxGroup, (void*) &value);
      }
    }
  }
}
