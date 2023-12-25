// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.LineRendererBuilder
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public sealed class LineRendererBuilder : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionParameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_LineRendererIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionIndex;

    static LineRendererBuilder()
    {
      Il2CppClassPointerStore<LineRendererBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (LineRendererBuilder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineRendererBuilder>.NativeClassPtr);
      LineRendererBuilder.NativeFieldInfoPtr_PositionParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineRendererBuilder>.NativeClassPtr, nameof (PositionParameter));
      LineRendererBuilder.NativeFieldInfoPtr_LineRendererIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineRendererBuilder>.NativeClassPtr, nameof (LineRendererIndex));
      LineRendererBuilder.NativeFieldInfoPtr_PositionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineRendererBuilder>.NativeClassPtr, nameof (PositionIndex));
    }

    public LineRendererBuilder(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LineRendererBuilder()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LineRendererBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineRendererBuilder>.NativeClassPtr, data));
    }

    public BlackboardParameterBuilder PositionParameter
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineRendererBuilder.NativeFieldInfoPtr_PositionParameter);
        return new BlackboardParameterBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineRendererBuilder.NativeFieldInfoPtr_PositionParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterBuilder>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int LineRendererIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineRendererBuilder.NativeFieldInfoPtr_LineRendererIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineRendererBuilder.NativeFieldInfoPtr_LineRendererIndex)) = value;
      }
    }

    public unsafe int PositionIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineRendererBuilder.NativeFieldInfoPtr_PositionIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LineRendererBuilder.NativeFieldInfoPtr_PositionIndex)) = value;
      }
    }
  }
}
